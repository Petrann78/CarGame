using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Traffic2 : MonoBehaviour
{
    public GameObject abc;


    void Start()
    {

    }


    // Start is called before the first frame update
    public void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0)) //this method checks if left click was pressed (GetMouseButtonDown(0) == left click)
        {
            Debug.Log("Pressed left click."); //display message to console
            abc.SetActive(true);// set abc gameobject to be active (to be visible), here the gameobject is the multiple choice window

        }


    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(1)) //checks if right click is pressed 
        {
            abc.SetActive(false); //set multiple choice window to not be visible
        }

    }
}
