using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public static ItemManager Instance { get; private set; }
    // Variabel untuk menyimpan skor item
    public int indomieCount;
    public int susuCount;
    public int sardenCount;
    public int micinCount;
    public int garamCount;
    public int penyedapRasaCount; // Tambah variabel penyedap rasa
    public int kecapCount; // Tambah variabel kecap
    public int mieCupCount; // Tambah variabel mie cup

  void Awake()
    {
        Instance = this; // Inisialisasi instance saat kelas ItemManager dibuat
        LoadPlayerPrefs();
        StartManager();
    }


    void LoadPlayerPrefs()
    {
        // Coba memuat skor item dari PlayerPrefs. Jika tidak ada, berikan nilai default (misalnya 0).
        indomieCount = PlayerPrefs.GetInt("IndomieCount", 0);
        susuCount = PlayerPrefs.GetInt("SusuCount", 0);
        sardenCount = PlayerPrefs.GetInt("SardenCount", 0);
        micinCount = PlayerPrefs.GetInt("MicinCount", 0);
        garamCount = PlayerPrefs.GetInt("GaramCount", 0);
        penyedapRasaCount = PlayerPrefs.GetInt("PenyedapRasaCount", 0); // Inisialisasi variabel penyedap rasa
        kecapCount = PlayerPrefs.GetInt("KecapCount", 0); // Inisialisasi variabel kecap
        mieCupCount = PlayerPrefs.GetInt("MieCupCount", 0); // Inisialisasi variabel mie cup
    }

      void StartManager()
    {
        
    }

    public void GetItemCount(string itemName, int value)
    {
        QuestManager.Instance.UpdateQuestItems();

        switch (itemName)
        {
            case "Indomie":
                indomieCount += value;
                PlayerPrefs.SetInt("IndomieCount", indomieCount);
                break;
            case "Susu":
                susuCount += value;
                PlayerPrefs.SetInt("SusuCount", susuCount);
                break;
            case "Sarden":
                sardenCount += value;
                PlayerPrefs.SetInt("SardenCount", sardenCount);
                break;
            case "Micin":
                micinCount += value;
                PlayerPrefs.SetInt("MicinCount", micinCount);
                break;
            case "Garam":
                garamCount += value;
                PlayerPrefs.SetInt("GaramCount", garamCount);
                break;
            case "PenyedapRasa": // Tambah case untuk item penyedap rasa
                penyedapRasaCount += value;
                PlayerPrefs.SetInt("PenyedapRasaCount", penyedapRasaCount);
                break;
            case "Kecap": // Tambah case untuk item kecap
                kecapCount += value;
                PlayerPrefs.SetInt("KecapCount", kecapCount);
                break;
            case "MieCup": // Tambah case untuk item mie cup
                mieCupCount += value;
                PlayerPrefs.SetInt("MieCupCount", mieCupCount);
                break;
            default:
                Debug.LogError("Item tidak dikenali: " + itemName);
                break;
        }
    }

    public void ResetItemCounts()
    {
        PlayerPrefs.DeleteKey("IndomieCount");
        PlayerPrefs.DeleteKey("SusuCount");
        PlayerPrefs.DeleteKey("SardenCount");
        PlayerPrefs.DeleteKey("MicinCount");
        PlayerPrefs.DeleteKey("GaramCount");
        PlayerPrefs.DeleteKey("PenyedapRasaCount"); // Hapus key penyedap rasa
        PlayerPrefs.DeleteKey("KecapCount"); // Hapus key kecap
        PlayerPrefs.DeleteKey("MieCupCount"); // Hapus key mie cup
        LoadPlayerPrefs();
        Debug.Log("Item count di-reset.");
    }
}
