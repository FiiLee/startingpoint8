using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

public class NameTags : MonoBehaviour
{
    public GameObject NameTag;

    private void Start()
    {
        NameTag.SetActive(false);
    }

    private void OnMouseOver()
    {
        NameTag.SetActive(true);
    }

    private void OnMouseExit()
    {
        NameTag.SetActive(false);
    }
}
