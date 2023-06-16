using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class managerUI : MonoBehaviour
{
    public Button[] buttons;
    public TMP_Text scoreText;
    public TMP_Text scoreText2;
    public GameObject gameObject;
    int score;
    bool game_over;
    string s;
    static int total_score = 0;
    static string[] previous_scores;
    public static bool play_has_been_called;
   public List<string> list = new List<string>();
    string res="";
    // Start is called before the first frame update
    void Start()
    {
        
     //   list = quiz2.getList();
        string scene_name = SceneManager.GetActiveScene().name;
        if (scene_name != "menu2Scene" || scene_name != "mapScene")
        {
            getStatsTest g = new getStatsTest();
            g.showScore();
        }
       
        game_over = false;
        //score = 0;
       
       
       
    }

    // Update is called once per frame
    void Update()
    {
       //
        
    }
    /*
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Npc car")
        {
            Destroy(gameObject);
           // Ui.gameOver = true;
        }
    }
    */
    void scoreUpdate()
    {
        if(!game_over)
        {
            score += 1;
        }
        Debug.Log(score);
    }

    public void gameOver()
    {

        game_over = true;
        foreach(Button button in buttons)
        {
            button.gameObject.SetActive(true);
        }
    }

    public void Pause() {
    
    if(Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }
    else if(Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
        
         foreach(Button button in buttons)
            {
                if(!button.gameObject.activeSelf)
                {
                        button.gameObject.SetActive(true);
                }
               else if (button.gameObject.activeSelf)
                {
                        button.gameObject.SetActive(false);
                }
            }
        
         
         
         
         

    }

    public void loadScene(string level_name)
    {
        //if (level_name =="level1")
        SceneManager.LoadScene(level_name);
        quiz2 q2 = new quiz2();
        q2.saveData();
        total_score =  q2.getData();
    }

    public void Play()
    {
        //Application.LoadLevel("lvl1Save7");
        SceneManager.LoadScene("mapScene");
        PlayerPrefs.DeleteKey("score_to_hold");
        total_score = 0;
        play_has_been_called = true;
    }
    public void Replay()
    {
        //Application.LoadLevel(Application.loadedLevel);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //quiz2.score = 0;
    }

    public void GoBackToMenu()
    {
        //Application.LoadLevel("menu2Scene");
        SceneManager.LoadScene("menu2Scene");
       // quiz2.score = 0;
    }
    public void Exit()
    {
        PlayerPrefs.DeleteKey("score_to_hold");
         Application.Quit();
    }

    public void showStats() {
        /* for (int j =0; j<list.Count; j++)
         {
             scoreText2.text = list[j];
         }*/
        quiz2 q3 = new quiz2();
        list=q3.getList();
        scoreText.text = "stats " + total_score + " correct answers out of 12 possible questions";
    
        for (int j=0; j<list.Count;j++)
        {
            res = res + "answer No "+ list[j] +" was wrong "+ "\n";
        }
        scoreText2.text = res;
    }

    public void exitToMap()
    {
        SceneManager.LoadScene("mapScene");
        // PlayerPrefs.DeleteKey("score_to_hold");
        //total_score = 0;
        quiz2 q2 = new quiz2();
        q2.saveData();
        total_score = q2.getData();
        play_has_been_called = true;
    }
}
