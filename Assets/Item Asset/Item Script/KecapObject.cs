using System.Diagnostics;
using UnityEngine;

public class KecapObject : MonoBehaviour
{
    [SerializeField] public ItemManager itemManager;
    [SerializeField] public QuestManager questmanager;

    private void OnMouseDown()
    {
        if (itemManager != null)
        {
            itemManager.GetItemCount("Kecap", 1);
            UnityEngine.Debug.Log("Kecap dapat 1");
            questmanager.UpdateItemCountText();
        }
        else
        {
            UnityEngine.Debug.LogError("ItemManager belum diinisialisasi di KecapObject.");
        }
    }
}