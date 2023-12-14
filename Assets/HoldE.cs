using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HoldE : MonoBehaviour
{
    public TextMeshProUGUI holdEText;
    public Image fillCircle; // Image untuk lingkaran yang akan diisi
    public Transform player;
    public string nextSceneName;

    public float holdDuration = 3f; // Durasi untuk memenuhi lingkaran fill
    private float holdTimer = 0f;
    private bool isHoldingE = false;

    public float distanceToShowText = 5f;

    private bool canTeleport = false;

    private void Update()
    {
        float distance = Vector3.Distance(player.position, transform.position);

        if (distance < distanceToShowText)
        {
            holdEText.enabled = true;

            if (Input.GetKeyDown(KeyCode.E) && canTeleport)
            {
                isHoldingE = true;
            }
        }
        else
        {
            holdEText.enabled = false;
        }

        // Memproses fill lingkaran jika sedang menekan E
        if (isHoldingE)
        {
            if (holdTimer < holdDuration)
            {
                holdTimer += Time.deltaTime;
                fillCircle.fillAmount = holdTimer / holdDuration;
            }
            else
            {
                LoadNextScene();
            }
        }
        else
        {
            // Reset fill dan timer jika tidak menekan tombol E
            holdTimer = 0f;
            fillCircle.fillAmount = 0f;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canTeleport = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canTeleport = false;
            isHoldingE = false; // Jika keluar, hentikan pengisian lingkaran
        }
    }

    private void LoadNextScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}
