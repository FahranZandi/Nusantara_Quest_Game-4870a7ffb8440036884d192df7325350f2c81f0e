using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class AnswerScript : MonoBehaviour
{
    public bool isCorrect = false;
    public QuizManager quizManager;
    public Color startColor;

    public void Start()
    {
        startColor = GetComponent<Image>().color;
    }
    public void Answer()
    {
        if (isCorrect)
        {
            Debug.Log("Correct Answer");
            // Add your logic for correct answer here
            quizManager.correct();
        }
        else
        {
            Debug.Log("Wrong Answer");
            // Add your logic for wrong answer here
            quizManager.wrong();
        }
    }
}
