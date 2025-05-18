using UnityEngine;
using UnityEngine.UI;    // ← tambahkan ini!
using System.Collections;
using System.Collections.Generic;

public class AnswerScript : MonoBehaviour
{
    public bool isCorrect = false;
    public QuizManager quizManager;
    public Color startColor;

    private Image img;      // cache Image component

    void Start()
    {
        // ambil komponen Image
        img = GetComponent<Image>();
        startColor = img.color;
    }

    public void Answer()
    {
        if (isCorrect)
        {
            img.color = Color.green;
            Debug.Log("Correct Answer");
            quizManager.correct();
        }
        else
        {
            img.color = Color.red;
            Debug.Log("Wrong Answer");
            quizManager.wrong();
        }
    }
}
