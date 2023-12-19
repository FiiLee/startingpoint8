using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUpText : MonoBehaviour
{
    GameObject player;
    [SerializeField] public GameObject PickUpText;

    private void Start()
    {
        PickUpText.gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PickUpText.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PickUpText.gameObject.SetActive(false);
        }
    }
}
