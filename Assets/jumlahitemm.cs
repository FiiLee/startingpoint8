using UnityEngine;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // Drag and drop UI Text TMP to this field in the Inspector.

    private void Start()
    {
        int indomieCount = PlayerPrefs.GetInt("Indomie", 0); // Mengambil jumlah indomie dari PlayerPrefs.

        // Set teks UI Text TMP dengan nilai indomie yang diambil dari PlayerPrefs.
        scoreText.text = indomieCount.ToString() + "/10" ;
    }
}
