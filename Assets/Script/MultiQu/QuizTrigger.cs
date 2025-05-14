using UnityEngine;

public class QuizTrigger : MonoBehaviour
{
    public GameObject quizCanvas;     // canvas utama pertanyaan (yang ada Panel-1 dan tombol)
    public GameObject questionPanel;  // bagian pertanyaan (Panel-1)
    public GameObject goPanel;        // panel Game Over (GoPanel)

    private bool playerInRange = false;
    private bool quizStarted = false;

    void Start()
    {
        quizCanvas.SetActive(false); // pastikan semuanya mati di awal
    }

    void Update()
    {
        if (playerInRange && !quizStarted && Input.GetKeyDown(KeyCode.E))
        {
            quizCanvas.SetActive(true);
            questionPanel.SetActive(true); // aktifkan Panel-1 (pertanyaan)
            goPanel.SetActive(false);      // pastikan panel game over belum tampil
            quizStarted = true;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
        }
    }
}
