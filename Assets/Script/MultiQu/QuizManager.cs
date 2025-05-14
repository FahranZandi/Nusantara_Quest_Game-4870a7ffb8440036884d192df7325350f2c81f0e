using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class QuizManager : MonoBehaviour
{
    public List<QuestionAnswer> Questions;  // Menggunakan Questions, bukan QnA
    public GameObject[] options;
    public int currentQuestion;

    public Text QuestionText;  // Menggunakan QuestionText, bukan QuestionTxt

    public GameObject QuistPanel;
    public GameObject GoPanel;

    public Text QuestionTxt;
    public Text ScoreTxt;
    int totalQuestion = 0;
    public int score;
 
    private void Start()
    {
        totalQuestion = Questions.Count;  // Menggunakan Questions, bukan QnA
        GoPanel.SetActive(false);
        generateQuestion();
    }

    public void retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        // Debug.Log("Retry");
        // Add logic to handle retry
    }

    public void GameOver()
    {
        QuistPanel.SetActive(false);
        // Debug.Log("Game Over");
        // Add logic to handle game over
        GoPanel.SetActive(true);
        ScoreTxt.text = score + "/" + totalQuestion;  // ✅ diubah dari hanya "/" + totalQuestion
        // Menggunakan Questions, bukan QnA
    }


    public void correct()
    {
        score += 1; // ketika benar
        Questions.RemoveAt(currentQuestion);  // Menggunakan Questions, bukan QnA
        generateQuestion();
    }

    public void wrong()
    {
        Questions.RemoveAt(currentQuestion);  // Menggunakan Questions, bukan QnA
        generateQuestion();
    }

    void setAnswers()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<AnswerScript>().isCorrect = false;  // Menggunakan AnswerScript, bukan Answer
            options[i].transform.GetChild(0).GetComponent<Text>().text = Questions[currentQuestion].Answers[i];  // Menggunakan Questions, bukan QnA

            if(Questions[currentQuestion].CorrectAnswer == i+1)  // Menggunakan Questions, bukan QnA
            {
                options[i].GetComponent<AnswerScript>().isCorrect = true;  // Menggunakan AnswerScript, bukan Answer
            }
        }

    }

    void generateQuestion()
    {

        if (Questions.Count > 0)
        {
            currentQuestion = Random.Range(0, Questions.Count);
            // currentQuestion = Random.Range(0, QnA.Count);  // Menggunakan Questions, bukan QnA

            QuestionText.text = Questions[currentQuestion].Question;  // Menggunakan Questions, bukan QnA, dan QuestionText, bukan QuestionTxt
            setAnswers();
        }
        else
        {
            Debug.Log("out of Questions");
            // Add logic to handle when there are no more questions
            GameOver();
        }

    }
}
