using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class ItemPlayerCollision : MonoBehaviour
{
    private int indomie = 0;
    [SerializeField] private Text ItemText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Indomie"))
        {
            Destroy(collision.gameObject);
            indomie++;
            ItemText.text = "Indomie = " + indomie + " / 20";
        }
    }

}
