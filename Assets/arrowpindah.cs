using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoaderOnClick : MonoBehaviour
{
    public int sceneIndex; // Index scene yang akan dimuat

    // Fungsi ini akan dipanggil saat tombol diklik pada UI
    public void LoadSceneOnClick()
    {
        // Melakukan perpindahan scene
        SceneManager.LoadScene(sceneIndex);
    }
}
