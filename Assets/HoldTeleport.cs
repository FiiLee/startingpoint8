using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HoldTeleport : MonoBehaviour
{
    public float holdDuration = 1f;
    public Image fillCircle; // Circle fill
    public string sceneName = "Store"; // Nama default scene
    private float holdTimer = 0;
    public bool isHolding = false;

    private static HoldTeleport instance; // Instance HoldTeleport yang akan disimpan

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Tetapkan objek HoldTeleport saat scene berubah
        }
        isHolding = false;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            isHolding = true;
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            ResetHold();
        }

        if (isHolding)
        {
            holdTimer += Time.deltaTime;
            fillCircle.fillAmount = holdTimer / holdDuration;
            if (holdTimer >= holdDuration)
            {
                SceneManager.LoadScene(sceneName);
            }
        }
    }

    private void ResetHold()
    {
        isHolding = false;
        holdTimer = 0;
        fillCircle.fillAmount = 0;
    }
    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
        {
        isHolding = false; // Set isHolding menjadi false saat scene terload
        }

    
}
