using UnityEngine;
using UnityEngine.UI;

public class FillCircleManager : MonoBehaviour
{
    public static FillCircleManager instance;
    public Image fillCircle;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
