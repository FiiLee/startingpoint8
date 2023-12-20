using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    public GameObject[] popUps;
    private int popUpsIndex;
    public GameObject NPC;

    private void Update()
    {
        for (int i = 1; i < popUps.Length; i++)
        {
            popUps[i].SetActive(i == popUpsIndex);
        }

        switch (popUpsIndex)
        {
            case 0:
                if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
                {
                    popUpsIndex++;
                    PlayerPrefs.SetInt("TutorialProgress", popUpsIndex);
                }
                break;

            case 1:
            case 2:
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    popUpsIndex++;
                    PlayerPrefs.SetInt("TutorialProgress", popUpsIndex);
                }
                break;
        }
    }

    private void Start()
    {
        // Ambil kemajuan tutorial dari PlayerPrefs
        popUpsIndex = PlayerPrefs.GetInt("TutorialProgress", 0);
    }
}
