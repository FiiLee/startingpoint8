using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    public GameObject canvasToHide1;
    public GameObject canvasToHide2;
    public GameObject canvasToHide3;
    public GameObject canvasToShow;
    public GameObject npcObject; // Objek NPC yang memiliki script NPCYA

    public void HideCanvas()
    {
        if (canvasToHide1 != null && canvasToHide2 != null && canvasToHide3 != null)
        {
            canvasToHide1.SetActive(false);
            canvasToHide2.SetActive(false);
            canvasToHide3.SetActive(false); // Meng-nonaktifkan ketiga canvas yang ingin disembunyikan
        }
    }

    public void SwitchCanvas()
    {
        if (canvasToHide1 != null && canvasToHide2 != null && canvasToHide3 != null && canvasToShow != null)
        {
            canvasToHide1.SetActive(false);
            canvasToHide2.SetActive(false);
            canvasToHide3.SetActive(false); // Menonaktifkan ketiga canvas yang ingin disembunyikan

            canvasToShow.SetActive(true); // Mengaktifkan canvas lain yang ingin ditampilkan

            // Mengubah isQuestTaken menjadi true pada script NPCYA yang ada pada objek NPC
            if (npcObject != null)
            {
                NPCYA npcScript = npcObject.GetComponent<NPCYA>();
                if (npcScript != null)
                {
                    npcScript.isQuestTaken = true;
                }
            }
        }
    }

    public void CompleteQuestButton()
    {
        HideCanvas();

        // Mengubah isQuestTaken dan isQuestCompleted menjadi false
        if (npcObject != null)
        {
            NPCYA npcScript = npcObject.GetComponent<NPCYA>();
            if (npcScript != null)
            {
                npcScript.isQuestTaken = false;
                npcScript.isQuestCompleted = false;
            }
        }
    }
}
