using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class quiz2 : MonoBehaviour
{
    public string s;
    public TMP_Text tmp;
   
    public GameObject inputField;
    public GameObject gameObject;
    public Text scoreText;
    int result;
    public static int score=0;
    public static int numberOfQuestionsToAnswer;
    int numberOfQuestions = 12;
    int counter,counter2=0;
    static List<string> list = new List<string>();
    //string showScoreString = "";
    // Start is called before the first frame update

    void Start()
    {
        //score = 0;
      /*  GameObject[] go = GameObject.FindGameObjectsWithTag("TrafficSign");

        for (int i = 0; i < go.Length; i++)
        {
            counter++;
        }
        Debug.Log(counter + " no of counter");
        numberOfQuestionsToAnswer = counter;*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void getText() {
       // string text = inputField.GetComponent<TMP_InputField>().text;
        s = inputField.GetComponent<TMP_Text>().text; //get the text of the inputfield GameObject (basicaly get the text of the question title)
        
        list.Add(s); //add the title to a list
        Debug.Log(s);//show the title to the console

    }

    public void scoreCounter()
    {
     if (managerUI.play_has_been_called == true) //if play has been called set score to 0, we do that so the score resets whenever we reload the game
        {
            score = 0;
        }
        score = score + 1; //when scoreCounter is called (whenever a correct answer is selected) add 1 to score
       
        Debug.Log("score is: " + score); //show score to console
        scoreText.text = "Score: " + score; // display score to scoreText field (Text component)
        /*if (score == numberOfQuestionsToAnswer)
        {
            SceneManager.LoadScene("mapScene");
        }
        */
        managerUI.play_has_been_called = false; //set variable play_has_been_called to false, so that score will not stay 0  
    }

    public void deleteGameObject()
    {
        Destroy(gameObject); //we call this function whenever the player answers a question, preventing him from answering it over and over again
        //gameObject.SetActive(false);
    }

    public void saveData() {
        PlayerPrefs.SetInt("score_to_hold", score); //using PlayerPrefs we save score to a variable we choose to be called score to be saved

        
    }
    public int getData()
    {
        return score; //this is a getter method to retrieve the score when we want
    }
    public List<string> getList()
    {
        return list;//this is a getter method that returns the above list when called 
    }
   
}
