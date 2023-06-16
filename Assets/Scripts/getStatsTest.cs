using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class getStatsTest : MonoBehaviour
{
    public TMP_Text statistics;
    public int numberOfQuestions=12;
    int tmp2;
    int stats;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showScore()
    {
        // tmp2 = quiz2.score / numberOfQuestions;
        //statistics.text = "You have a score of: " + tmp2;
        int score2 = PlayerPrefs.GetInt("score_to_hold");//using PlayerPrefs function we save current score to score2 variable, so that after we change scenes it's not deleted
        stats = score2 / numberOfQuestions;// we get average value
        Debug.Log("total score " + score2);// we display score to console
    }
}
