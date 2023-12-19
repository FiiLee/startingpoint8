using UnityEngine;
using UnityEngine.UI;

public class Questni : MonoBehaviour
{
    public bool buttonIsClicked1 = false;
    public bool buttonIsClicked2 = false;
    private Animator animator;
    public GameObject tutup;

    public void TombolSilang1()
    {
        buttonIsClicked1 = true;
        buttonIsClicked2 = false;
        Debug.Log("Button 1 Clicked!");
        tutup.SetActive(false);
    }

    public void TombolSilang2()
    {
        buttonIsClicked1 = false;
        buttonIsClicked2 = true;
        Debug.Log("Button 2 Clicked!");
    }
}
