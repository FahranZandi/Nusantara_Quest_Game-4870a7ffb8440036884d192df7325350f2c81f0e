using UnityEngine;
using UnityEngine.UI;    // ← jangan lupa!

public class AnswerScript : MonoBehaviour
{
    public bool isCorrect = false;
    public QuizManager quizManager;
    public Color startColor;

   // private Image img;      // cache Image component

    void Start()
    {
        // ambil komponen Image & simpan warna awal
        //img = GetComponent<Image>();
        //startColor = img.color;
    }

    // dipanggil saat klik jawaban
    public void Answer()
    {
        if (isCorrect)
        {
            //img.color = Color.green;
            Debug.Log("Correct Answer");
            quizManager.correct();
        }
        else
        {
            //img.color = Color.red;
            Debug.Log("Wrong Answer");
            quizManager.wrong();
        }
    }

    // reset warna ke startColor
    public void ResetColor()
    {
        //img.color = startColor;
    }
}
