using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class QuizManager : MonoBehaviour
{
    public List<QnA> qna_list;
    public GameObject[] options;
    public int current_question;
    public Text Qtext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        getQuestion();   
    }

    void getQuestion()
    {
        Qtext.text = qna_list[current_question].question;
        Debug.Log(Qtext);
    }
    void getOptions()
    {
        for (int i=0; i< options.Length; i++)
        {
            options[i].GetComponent<AnswerScript>().is_correct = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = qna_list[current_question].answers[i];

            if(qna_list[current_question].correct_choice_index == i+1)
            {
                options[i].GetComponent<AnswerScript>().is_correct = true;
            }
        }
       
    }
}
