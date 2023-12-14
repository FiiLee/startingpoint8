using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class Timer : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private Image uiFill;
    [SerializeField] private TextMeshProUGUI uiText;

    public int duration;

    private int remainingDuration;
    private bool pause;

    public Canvas endCanvas; // Referensi ke canvas yang ingin diaktifkan saat timer berakhir

    private void Start()
    {
        Begin(duration);
    }

    private void Begin(int seconds)
    {
        remainingDuration = seconds;
        StartCoroutine(UpdateTimer());
    }

    private IEnumerator UpdateTimer()
    {
        while (remainingDuration >= 0)
        {
            if (!pause)
            {
                uiText.text = $"{remainingDuration / 60:00}:{remainingDuration % 60:00}";
                uiFill.fillAmount = Mathf.InverseLerp(0, duration, remainingDuration);
                remainingDuration--;
                yield return new WaitForSeconds(1f);
            }
            yield return null;
        }
        OnEnd();
    }

    private void OnEnd()
    {
        if (endCanvas != null)
        {
            endCanvas.gameObject.SetActive(true); // Aktifkan canvas saat timer berakhir
        }
        else
        {
            Debug.LogWarning("End Canvas reference is missing!");
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        pause = !pause;
    }
}
