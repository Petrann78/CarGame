using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interaction : MonoBehaviour
{
    public GameObject abc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision detected!");
        abc.SetActive(true);//When gameObject collides set abc gameObject active, in other words make abc visible, we do that to make pop up window visible when clicked.
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
