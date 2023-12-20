using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public ItemManager itemManager;
    public Animator playerAnimator; // Animator untuk mengelola animasi pemain
    private bool isAnimating = false; // Flag untuk menandai apakah animasi sedang berjalan

    // Method yang akan dipanggil saat tombol Indomie diklik
    public void OnIndomieButtonClick()
    {
        PlayAnimationAndAddItem("Indomie");
    }
        public void OnSusuButtonClick()
    {
        PlayAnimationAndAddItem("Susu");
    }

    // Method yang akan dipanggil saat tombol Sarden diklik
    public void OnSardenButtonClick()
    {
        PlayAnimationAndAddItem("Sarden");
    }

    // Method yang akan dipanggil saat tombol Micin diklik
    public void OnMicinButtonClick()
    {
        PlayAnimationAndAddItem("Micin");
    }

    // Method yang akan dipanggil saat tombol Garam diklik
    public void OnGaramButtonClick()
    {
        PlayAnimationAndAddItem("Garam");
    }

    // Method yang akan dipanggil saat tombol Penyedap Rasa diklik
    public void OnPenyedapRasaButtonClick()
    {
        PlayAnimationAndAddItem("PenyedapRasa");
    }

    // Method yang akan dipanggil saat tombol Kecap diklik
    public void OnKecapButtonClick()
    {
        PlayAnimationAndAddItem("Kecap");
    }

    // Method yang akan dipanggil saat tombol Mie Cup diklik
    public void OnMieCupButtonClick()
    {
        PlayAnimationAndAddItem("MieCup");
    }


    // Method untuk memainkan animasi dan menambah item
    private void PlayAnimationAndAddItem(string itemName)
    {
        if (!isAnimating)
        {
            isAnimating = true;
            StartCoroutine(PlayAndAddCoroutine(itemName));
        }
    }

    private System.Collections.IEnumerator PlayAndAddCoroutine(string itemName)
    {
        playerAnimator.Play("PickUpUP"); // Memutar animasi pickUpUP
        
        // Tunggu hingga animasi selesai (disesuaikan dengan durasi animasi sebenarnya)
        yield return new WaitForSeconds(1.0f);

        itemManager.GetItemCount(itemName, 1); // Menambahkan item ke ItemManager
        SaveItem(itemName); // Menyimpan jumlah item ke PlayerPrefs
        
        isAnimating = false; // Animasi selesai
    }

    // Method untuk menyimpan jumlah item ke PlayerPrefs
    private void SaveItem(string itemName)
    {
    switch (itemName)
        {
        case "Indomie":
            PlayerPrefs.SetInt("IndomieCount", itemManager.indomieCount);
            break;
        case "Susu":
            PlayerPrefs.SetInt("SusuCount", itemManager.susuCount);
            break;
        case "Sarden":
            PlayerPrefs.SetInt("SardenCount", itemManager.sardenCount);
            break;
        case "Micin":
            PlayerPrefs.SetInt("MicinCount", itemManager.micinCount);
            break;
        case "Garam":
            PlayerPrefs.SetInt("GaramCount", itemManager.garamCount);
            break;
        case "PenyedapRasa":
            PlayerPrefs.SetInt("PenyedapRasaCount", itemManager.penyedapRasaCount);
            break;
        case "Kecap":
            PlayerPrefs.SetInt("KecapCount", itemManager.kecapCount);
            break;
        case "MieCup":
            PlayerPrefs.SetInt("MieCupCount", itemManager.mieCupCount);
            break;
        default:
            Debug.LogError("Item tidak dikenali: " + itemName);
            break;
        }
        PlayerPrefs.Save(); // Untuk menyimpan perubahan ke PlayerPrefs secara langsung
    }
}

    
    
    
    
    
    
    
    
    
    
    
    