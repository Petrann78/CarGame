using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrafficSignButton : MonoBehaviour
{
    string nameOfObject;
    public GameObject MultipleChoiceWindow;
    public GameObject backGround;
    public GameObject FrontGround;
    public Button _button;

    void Awake()
    {

        _button = GetComponent<Button>();
        _button.onClick.AddListener(btnClick);
      // if (MultipleChoiceWindow.name == "Multiple_choice_window")
        //MultipleChoiceWindow = GetComponent<GameObject>();
    } 
    void btnClick()
    {

        MultipleChoiceWindow.SetActive(true);
      /*  if (MultipleChoiceWindow.activeSelf)
        {
            // If the window is already open, close it
            MultipleChoiceWindow.SetActive(false);
        }
        else if (!MultipleChoiceWindow.activeSelf)
        {
            // If the window is not open, open it
            MultipleChoiceWindow.SetActive(true);
        }
    */}
    
    


}
