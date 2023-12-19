using UnityEngine;

public class NPCYA : MonoBehaviour
{
    public GameObject canvasQuestAvailable; // Canvas ketika quest tersedia
    public GameObject canvasQuestInProgress; // Canvas ketika quest sedang berlangsung
    public GameObject canvasQuestComplete; // Canvas ketika quest selesai

    public bool isQuestTaken = false;
    public bool isQuestCompleted = false;
    public bool isInRange = false;

    private void Update()
    {
        if (isInRange && Input.GetKeyDown(KeyCode.E))
        {
            if (!isQuestTaken)
            {
                // Quest belum diambil
                canvasQuestAvailable.SetActive(true);
            }
            else if (isQuestTaken && !isQuestCompleted)
            {
                // Quest sudah diambil tetapi belum selesai
                canvasQuestInProgress.SetActive(true);
            }
            else if (isQuestTaken && isQuestCompleted)
            {
                // Quest sudah selesai
                canvasQuestComplete.SetActive(true);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isInRange = true; // Player berada dalam jangkauan
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isInRange = false; // Player keluar dari jangkauan
            // Semua canvas dinonaktifkan saat player keluar dari jangkauan
            canvasQuestAvailable.SetActive(false);
            canvasQuestInProgress.SetActive(false);
            canvasQuestComplete.SetActive(false);
        }
    }
}
