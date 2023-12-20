using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public string sceneName; // Nama dari scene yang akan dituju

    public void LoadByName()
    {
        SceneManager.LoadScene(sceneName);
        Time.timeScale = 1;
    }
}
