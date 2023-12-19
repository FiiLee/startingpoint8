using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public bool isHolding = false;
    [SerializeField] private GameObject _startingSceneTransition;
    [SerializeField] private GameObject _endingSceneTransition;

    // Start is called before the first frame update
    private void Start()
    {
        _startingSceneTransition.SetActive(true);
        Invoke("DisableStartingSceneTransition", 1.5f);
        isHolding = false;
    }

    // Update is called once per frame
    private void DisableStartingSceneTransition()
    {
        _startingSceneTransition.SetActive(false);
    }

     private void Update()
    {
    }

    private void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }



    

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Set isHolding menjadi false saat scene terload
        isHolding = false;
    }



    // ... fungsi-fungsi lain yang diperlukan untuk manajemen permainan ...
}
