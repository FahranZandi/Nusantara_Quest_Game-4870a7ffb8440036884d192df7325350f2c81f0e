using UnityEngine;

public class QuizTrigger : MonoBehaviour {
    public GameObject quizCanvas;
    private bool playerInRange = false;

    void Update() {
        if (playerInRange && Input.GetKeyDown(KeyCode.E)) {
            quizCanvas.SetActive(true);
        }
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            playerInRange = true;
        }
    }

    void OnTriggerExit2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            playerInRange = false;
        }
    }
}
