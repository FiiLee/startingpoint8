using UnityEngine;

public class itemkeranjang : MonoBehaviour
{
    public int Indomie = 0; // Variabel untuk menyimpan skor "Indomie"

    // Metode untuk menambah skor Indomie
    public void GetIndomie(int value)
    {
        Indomie += value;
        Debug.Log("Beli Mie satu " + value.ToString());

        // Simpan "Indomie" ke PlayerPrefs
        PlayerPrefs.SetInt("Indomie", Indomie);

        // Periksa apakah Indomie lebih besar dari 20
        if (Indomie > 20)
        {
            // Hapus kunci "Indomie" dari PlayerPrefs
            PlayerPrefs.DeleteKey("Indomie");
            Debug.Log("Skor Indomie dihapus karena melebihi 20.");
        }
    }

    void Awake()
    {
        // Coba memuat "Indomie" dari PlayerPrefs. Jika tidak ada, berikan nilai default (misalnya 0).
        Indomie = PlayerPrefs.GetInt("Indomie", 0);

        // Muat kemajuan tutorial dari PlayerPrefs dan simpan ke PlayerPrefs "TutorialProgress"
        int tutorialProgress = PlayerPrefs.GetInt("TutorialProgress", 0);
        PlayerPrefs.SetInt("TutorialProgress", tutorialProgress);
    }

    void Update()
    {
        // Reset tutorial progress jika tombol "P" ditekan
        if (Input.GetKeyDown(KeyCode.P))
        {
            PlayerPrefs.DeleteKey("TutorialProgress");
            Debug.Log("Tutorial progress di-reset.");
        }
    }

    // Metode lain dan kode pemain lainnya
}
