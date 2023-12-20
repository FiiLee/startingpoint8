using System.Diagnostics;
using UnityEngine;

public class GaramObject : MonoBehaviour
{
    [SerializeField] public ItemManager itemManager;
    [SerializeField] public QuestManager questmanager;

    private void OnMouseDown()
    {
        if (itemManager != null)
        {
            itemManager.GetItemCount("Garam", 1);
            UnityEngine.Debug.Log("Garam dapat 1");
            questmanager.UpdateItemCountText();
        }
        else
        {
            UnityEngine.Debug.LogError("ItemManager belum diinisialisasi di GaramObject.");
        }
    }
}