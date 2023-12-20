using UnityEngine;
using TMPro;

public class QuestManager : MonoBehaviour
{
    public GameObject shoppingListCanvas;
    public TextMeshProUGUI[] shoppingItems;

    private string[] itemList = { "Susu", "Indomie", "Garam", "Sarden", "Micin", "Penyedap Rasa", "Kecap", "Mie Cup" };
    private ItemManager itemManager;
    
    private void Start()
    {
        shoppingListCanvas.SetActive(false);
        
        GameObject playerObject = GameObject.FindGameObjectWithTag("Player"); 
        if (playerObject != null)
        {
            itemManager = playerObject.GetComponent<ItemManager>();
        }

        if (itemManager == null)
        {
            Debug.LogError("Tidak bisa menemukan ItemManager pada objek player.");
        }
        else
        {
            UpdateItemCountText(); 
        }
    }
    
    public static QuestManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    public void UpdateQuestItems()
    {
        ShuffleAndDisplayItems();
    }

    public void StartQuest()
    {
        shoppingListCanvas.SetActive(true);
        ShuffleAndDisplayItems();
    }

    private void ShuffleAndDisplayItems()
    {
        ShuffleItems();
    // Menampilkan 4 item yang diacak ke dalam list belanja
        for (int i = 0; i < shoppingItems.Length; i++)
        {
            int count = 0;

        // Ambil nilai aktual dari ItemManager berdasarkan nama item
        switch (itemList[i])
        {
            case "Indomie":
                count = itemManager.indomieCount;
                break;
            case "Susu":
                count = itemManager.susuCount;
                break;
            case "Sarden":
                count = itemManager.sardenCount;
                break;
            case "Micin":
                count = itemManager.micinCount;
                break;
            case "Kecap":
                count = itemManager.kecapCount;
                break;
            case "Penyedap Rasa":
                count = itemManager.penyedapRasaCount;
                break;
            case "Mie Cup":
                count = itemManager.mieCupCount;
                break;
            case "Garam":
                count = itemManager.garamCount;
                break;        
            // Tambahkan kasus lain untuk item lainnya
        }
        
        int requiredCount = Random.Range(1, 11);
        count = Mathf.Min(count, requiredCount);
        shoppingItems[i].text = itemList[i] + " " + count + "/" + requiredCount; // Menampilkan nama barang dan jumlah yang harus diambil
        }
    }

     void UpdateItemCountText()
    {
        // Mengambil nilai indomieCount dari ItemManager dan menampilkannya di console
        Debug.Log("Jumlah Indomie: " + itemManager.indomieCount);
    }

    private void ShuffleItems()
    {
        // Mengacak item dengan menggunakan algoritma Fisher-Yates
        for (int i = 0; i < itemList.Length - 1; i++)
        {
            int randomIndex = Random.Range(i, itemList.Length);
            string temp = itemList[i];
            itemList[i] = itemList[randomIndex];
            itemList[randomIndex] = temp;
        }
    }
}
