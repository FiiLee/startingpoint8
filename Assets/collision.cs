using UnityEngine;
using TMPro;

public class ShowTextOnCollision : MonoBehaviour
{
    public GameObject LoadCanvas;
    private bool playerInsideCollider;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player entered the collider!");
            playerInsideCollider = true;

            if (LoadCanvas != null)
            {
                LoadCanvas.SetActive(true); // Tampilkan teks jika objek tidak null
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInsideCollider = false;

            if (LoadCanvas != null)
            {
                LoadCanvas.SetActive(false); // Sembunyikan teks jika objek tidak null
            }
        }
    }
}
