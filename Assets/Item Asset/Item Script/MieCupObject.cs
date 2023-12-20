using System.Diagnostics;
using UnityEngine;

public class MieCupObject : MonoBehaviour
{
    [SerializeField] public ItemManager itemManager;
    [SerializeField] public QuestManager questmanager;

    private void OnMouseDown()
    {
        if (itemManager != null)
        {
            itemManager.GetItemCount("MieCup", 1);
            UnityEngine.Debug.Log("MieCup dapat 1");
            questmanager.UpdateItemCountText();
        }
        else
        {
            UnityEngine.Debug.LogError("ItemManager belum diinisialisasi di MieCupObject.");
        }
    }
}