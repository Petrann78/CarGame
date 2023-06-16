using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Button = UnityEngine.UI.Button;

public class QuizManager2 : MonoBehaviour
{
    //public GameObject gameObject;
    public Button[] buttons2;
    public string[] answers;
    public Button correct_button;
    public Button wrong_button;
    public Button wrong_button2;
    public int correct_answer_index=2;
    private int ind, score = 0;

    // Start is called before the first frame update
    
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void checkAnswers()
    {
        buttons2 = new Button[3];
        correct_button = buttons2[correct_answer_index];
       correct_button.onClick.AddListener(correctAnswerClicked);

        for (int i = 0; i < buttons2.Length; i++)
        {
            if (i != correct_answer_index)
            {
                buttons2[i].onClick.AddListener(wrongAnswerClicked);
               }


        }
    }

    public void correctAnswerClicked()
    {
        score = score + 1;
        Debug.Log("correct button pressed");
    }



    public void wrongAnswerClicked()
    {
        Debug.Log("wrong button pressed");


    }

}
