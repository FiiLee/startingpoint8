using UnityEngine;

public class IndomieSimpan : MonoBehaviour
{
    public int Indomie = 0;

    // Metode untuk menambah skor Indomie
    public void GetIndomie(int value)
    {
        Indomie += value;
        Debug.Log("Beli Mie satu " + value.ToString());

        // Simpan "Indomie" ke PlayerPrefs
        PlayerPrefs.SetInt("Indomie", Indomie);

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
    }

    // Metode lain dan kode pemain lainnya
}
