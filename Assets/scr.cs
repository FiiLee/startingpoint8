using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneByName : MonoBehaviour
{
    public string sceneName; // Nama dari scene yang akan dituju

    public void LoadSceneByName()
    {
        SceneManager.LoadScene(sceneName);
    }
}
