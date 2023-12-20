using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroyExceptScene : MonoBehaviour
{
    public string sceneNameToDestroy; // Nama scene yang akan menghancurkan objek

    private void Awake()
    {
        DontDestroyOnLoad(gameObject); // Objek tidak akan hancur saat pindah scene
    }

    private void Start()
    {
        SceneManager.sceneLoaded += OnSceneLoaded; // Event ketika scene ter-load
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Cek jika scene yang dimuat adalah scene yang ingin menghancurkan objek
        if (scene.name == sceneNameToDestroy)
        {
            Destroy(gameObject); // Hancurkan objek saat masuk ke scene tertentu
        }
    }

    // Pastikan untuk melepas event listener saat objek dihancurkan atau scene selesai dimuat
    private void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
    
}
