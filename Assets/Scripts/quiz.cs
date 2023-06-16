using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quiz : MonoBehaviour
{

    public int score=0;
    public GameObject gameObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


   public void scoreCounter() {
        score = score + 1;
        Debug.Log(score);
    }
   public void deleteGameObject()
    {
        Destroy(gameObject);
    }
   
}
