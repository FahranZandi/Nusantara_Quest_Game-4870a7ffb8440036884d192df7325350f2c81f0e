using UnityEngine;
using UnityEngine.UI;

public class MultipleChoiceQuiz : MonoBehaviour {
    /*[TextArea]
    public string questionText;
    public string[] choices;
    public int correctAnswerIndex;

    public Text questionUI;
    public Button[] answerButtons;
    public Text resultText;

    public GameObject rewardItem; // prefab item hadiahnya

    private bool answered = false;

    void Start() {
        ShowQuestion();
    }

    void ShowQuestion() {
        questionUI.text = questionText;
        for (int i = 0; i < answerButtons.Length; i++) {
            int index = i;
            answerButtons[i].GetComponentInChildren<Text>().text = choices[i];
            answerButtons[i].onClick.AddListener(() => OnAnswer(index));
        }
    }

    void OnAnswer(int index) {
        if (answered) return;
        answered = true;

        if (index == correctAnswerIndex) {
            resultText.text = "Benar! Kamu mendapatkan item!";
            if (rewardItem != null) {
                Instantiate(rewardItem, transform.position + Vector3.up, Quaternion.identity);
            }
        } else {
            resultText.text = "Salah... Coba lagi nanti.";
        }
    }*/
}
