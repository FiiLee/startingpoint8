using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] public GameObject pausing;

    public void Pause()
    {
        pausing.SetActive(true);
        Time.timeScale = 0;
    }

    public void Resume()
    {
        pausing.SetActive(false);
        Time.timeScale = 1;
    }
}
