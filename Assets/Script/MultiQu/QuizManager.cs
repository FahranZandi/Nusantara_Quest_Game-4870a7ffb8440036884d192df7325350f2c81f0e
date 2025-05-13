using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    public List<QuestionAnswer> Questions;  // Menggunakan Questions, bukan QnA
    public GameObject[] options;
    public int currentQuestion;

    public Text QuestionText;  // Menggunakan QuestionText, bukan QuestionTxt

    private void Start()
    {
        generateQuestion();
    }


    public void correct()
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
        } else
        {
            Debug.Log("out of Questions");
            // Add logic to handle when there are no more questions
        }

    }
}
