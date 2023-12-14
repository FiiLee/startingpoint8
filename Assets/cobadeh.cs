using UnityEngine;
using UnityEngine.UI;

public class CollisionFill : MonoBehaviour
{
    public Image fillImage; // Pasangkan image knob ke sini di Inspector
    public float fillTime = 3f; // Waktu yang dibutuhkan untuk mengisi fill
    private float holdTimer = 0f; // Timer untuk menahan tombol
    private bool isFilling = false; // Status untuk mengisi

    void Update()
    {
        // Mengecek apakah pemain ada di dalam collider dan menahan tombol E
        if (isFilling)
        {
            if (Input.GetKey(KeyCode.E))
            {
                holdTimer += Time.deltaTime;

                // Mengisi fill secara bertahap berdasarkan waktu yang ditentukan
                fillImage.fillAmount = Mathf.Clamp01(holdTimer / fillTime);

                // Jika fill sudah penuh
                if (fillImage.fillAmount >= 1.0f)
                {
                    // Lakukan aksi yang diinginkan setelah proses pengisian selesai
                    // Contoh: teleportasi pemain atau aksi tertentu
                }
            }
            else
            {
                // Reset timer jika tombol E dilepas sebelum waktu penuh
                holdTimer = 0f;
                isFilling = false;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player entered the collider!");
            isFilling = true; // Pemain masuk ke collider, memungkinkan pengisian fill
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Jika pemain keluar dari collider, hentikan pengisian fill
            holdTimer = 0f;
            isFilling = false;
            fillImage.fillAmount = 0f; // Kembalikan fill ke nol
        }
    }
}
