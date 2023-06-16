using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerScript : MonoBehaviour
{
    public bool is_correct = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Answer()
    {
        if (is_correct)
        {
            Debug.Log("correct answer!");
        }
        else
        {
            Debug.Log("incorrect answer!");
        }
    }
}
