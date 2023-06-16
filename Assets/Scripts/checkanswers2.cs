using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Button = UnityEngine.UI.Button;

public class checkanswers2 : MonoBehaviour
{
    public Button[] buttons2;
    public QuizManager2 quizManager;
    // Start is called before the first frame update
    void Start()
    {
        
       // checkAnswers();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void check()
    {
         quizManager = GameObject.Find("QuizManager2").GetComponent<QuizManager2>();
        buttons2 = FindObjectsOfType<Button>();
        quizManager.checkAnswers();


    }



}
