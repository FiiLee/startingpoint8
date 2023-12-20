using System.Diagnostics;
using UnityEngine;

public class PenyedapRasaObject : MonoBehaviour
{
    [SerializeField] public ItemManager itemManager;
    [SerializeField] public QuestManager questmanager;

    private void OnMouseDown()
    {
        if (itemManager != null)
        {
            itemManager.GetItemCount("PenyedapRasa", 1);
            UnityEngine.Debug.Log("PenyedapRasa dapat 1");
            questmanager.UpdateItemCountText();
        }
        else
        {
            UnityEngine.Debug.Log("ItemManager belum diinisialisasi di PenyedapRasaObject.");
        }
    }
}