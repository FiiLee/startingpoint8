using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class cobaholdlogic : MonoBehaviour
{
    public float holdDuration2 = 5f;
    public Image fillCircle2; // Circle fill
    public string sceneName2 = "Store"; // Nama default scene
    private float holdTimer2 = 0;
    public bool isHolding2 = false;

    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            isHolding2 = true;
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            ResetHold2();
        }

        if (isHolding2)
        {
            holdTimer2 += Time.deltaTime;
            fillCircle2.fillAmount = holdTimer2 / holdDuration2;
            if (holdTimer2 >= holdDuration2)
            {
                SceneManager.LoadScene(sceneName2);
            }
        }
    }

    private void ResetHold2()
    {
        isHolding2 = false;
        holdTimer2 = 0;
        fillCircle2.fillAmount = 0;
    }
}
