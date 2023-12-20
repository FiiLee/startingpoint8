using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IndomieObject : MonoBehaviour
{
    [SerializeField] public ItemManager itemSets;
    [SerializeField] public QuestManager managequest;

    public void OnMouseDown()
    {
        if (itemSets != null)
        {
            itemSets.GetItemCount("Indomie", 1);
            UnityEngine.Debug.Log("Indomie dapat 1");
            managequest.UpdateItemCountText();
        }
        else
        {
            UnityEngine.Debug.LogError("ItemManager belum diinisialisasi di IndomieObject.");
        }
    }
}