using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizManager : MonoBehaviour
{
    public List<QuestionAnswer> Questions;
    private List<QuestionAnswer> originalQuestions; // (ditambah) menyimpan salinan asli pertanyaan
    public GameObject[] options;
    public int currentQuestion;

    public Text QuestionText;

    public GameObject QuistPanel;
    public GameObject GoPanel;
    public GameObject quizCanvas; // (ditambah) referensi ke quiz canvas utama

    public Text QuestionTxt;
    public Text ScoreTxt;
    public Button actionButton; // (ditambah) tombol retry/continue
    public Text actionButtonText; // (ditambah) teks tombol
    int totalQuestion = 0;
    public int score;

    private void Start()
    {
        originalQuestions = new List<QuestionAnswer>(Questions); // (ditambah) simpan pertanyaan asli
        totalQuestion = Questions.Count;
        GoPanel.SetActive(false);
        generateQuestion();
    }

    public void retry()
    {
        // (diubah) bukan me-reload scene, tapi reset quiz
        Questions = new List<QuestionAnswer>(originalQuestions); // reset pertanyaan
        score = 0; // reset score
        GoPanel.SetActive(false);
        QuistPanel.SetActive(true);
        generateQuestion(); // generate ulang
    }

    public void GameOver()
    {
        QuistPanel.SetActive(false);
        GoPanel.SetActive(true);
        ScoreTxt.text = score + "/" + totalQuestion;

        if (score == totalQuestion)
        {
            actionButtonText.text = "Continue"; // (ditambah) ubah tulisan tombol
            actionButton.onClick.RemoveAllListeners(); // hapus listener sebelumnya
            actionButton.onClick.AddListener(() =>
            {
                quizCanvas.SetActive(false); // (ditambah) sembunyikan canvas
            });
        }
        else
        {
            actionButtonText.text = "Ulangi"; // (ditambah) ubah tulisan tombol
            actionButton.onClick.RemoveAllListeners(); // hapus listener sebelumnya
            actionButton.onClick.AddListener(retry); // panggil retry
        }
    }

    public void correct()
    {
        score += 1;
        Questions.RemoveAt(currentQuestion);
        generateQuestion();
    }

    public void wrong()
    {
        Questions.RemoveAt(currentQuestion);
        generateQuestion();
    }

    void setAnswers()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<AnswerScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Image>().sprite = Questions[currentQuestion].Answers[i];

            if(Questions[currentQuestion].CorrectAnswer == i+1)
            {
                options[i].GetComponent<AnswerScript>().isCorrect = true;
            }
        }
    }

    void generateQuestion()
    {
        if (Questions.Count > 0)
        {
            currentQuestion = Random.Range(0, Questions.Count);
            QuestionText.text = Questions[currentQuestion].Question;
            setAnswers();
        }
        else
        {
            Debug.Log("out of Questions");
            GameOver();
        }
    }
}
