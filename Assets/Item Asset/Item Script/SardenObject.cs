using System.Diagnostics;
using UnityEngine;

public class SardenObject : MonoBehaviour
{
    [SerializeField] public ItemManager itemManager;
    [SerializeField] public QuestManager questmanager;

    private void OnMouseDown()
    {
        if (itemManager != null)
        {
            itemManager.GetItemCount("Sarden", 1);
            UnityEngine.Debug.Log("Sarden dapat 1");
            questmanager.UpdateItemCountText();
        }
        else
        {
            UnityEngine.Debug.LogError("ItemManager belum diinisialisasi di SardenObject.");
        }
    }
}