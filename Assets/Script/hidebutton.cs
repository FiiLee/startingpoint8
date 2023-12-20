using UnityEngine;
using UnityEngine.UI;

public class tombolbuathide: MonoBehaviour
{
    public GameObject Buttontohide1;
    public GameObject Buttontohide2;

    public void HideButton()
    {
        
            Buttontohide1.SetActive(false);    
        
    }

     public void ShowButton()
    {
        
            Buttontohide1.SetActive(true);    
        
    }
        public void HideButton2()
    {
        
            Buttontohide2.SetActive(false);    
        
    }

     public void ShowButton2()
    {
        
            Buttontohide2.SetActive(true);    
        
    }
    public void Showboth()
    {
        Buttontohide1.SetActive(true);   
        Buttontohide2.SetActive(true);    
    }
    public void HideBoth()
    {
        Buttontohide1.SetActive(false);    
        Buttontohide2.SetActive(false);   
    }
 
}