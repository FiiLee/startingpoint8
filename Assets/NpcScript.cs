using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NPC : MonoBehaviour
{
    public GameObject dialoguePanel;
    public TextMeshProUGUI dialogueText;
    public string[] dialogue;
    private int index = 0;
    private bool isTyping = false;
    public float wordSpeed;
    public bool playerIsClose = false;
    public GameObject TeksInteraksi;
    public string npcName;
    public TextMeshProUGUI npcNameText;
    public GameObject NextButton;
    public GameObject questPanel1;
    public GameObject questPanel2;
    public bool Tutorial2 = false;
    private int indomieCount;
    
    void Start()

    {
        dialogueText.text = "";
        indomieCount = PlayerPrefs.GetInt("Indomie", 0); // Mengambil jumlah indomie dari PlayerPrefs
    }

    // Update is called once per frame
    void Update()
{
        if (Input.GetKeyDown(KeyCode.E) && playerIsClose && dialoguePanel.activeSelf == false)
    {
            dialoguePanel.SetActive(true);
            npcNameText.text = npcName;
            Tutorial2 = true;

             if (!isTyping)
             {
            StartCoroutine(Typing());
            }

            TeksInteraksi.SetActive(false);
    }
        else if (dialogueText.text == dialogue[index] && dialoguePanel.activeSelf == true)
    {
            NextLine();
    }

    // Sisanya tetap seperti yang Anda miliki...
}
    public void RemoveText()
    {
        // Hanya hapus teks jika pengetikan sudah selesai
        if (!isTyping)
        {
            dialogueText.text = "";
            index = 0;
            dialoguePanel.SetActive(false);
        }
    }

    IEnumerator Typing()
    {
        isTyping = true; // pengetikan sedang berlangsung

        foreach (char letter in dialogue[index].ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(wordSpeed);
        }

        isTyping = false; // Pengetikan sudah selesai
    }

    public void NextLine()
    {
        NextButton.SetActive(false);

        if (index < dialogue.Length - 1)
        {
            index++;
            dialogueText.text = "";
            StartCoroutine(Typing());
        }
        else
        {
            RemoveText();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = true;
            TeksInteraksi.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = false;
            RemoveText();
            TeksInteraksi.SetActive(false);
        }
    }
}
