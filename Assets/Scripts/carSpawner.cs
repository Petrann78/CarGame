using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carSpawner : MonoBehaviour
{
    public GameObject[] cars; //here we have put certain sprites / carsfrom inside unity.
    public float maxPosX=0.255f;
    public float minPosX=-3.545f;
    public float delayTimer = 5f;
    float timer;
    int carNo;
    // Start is called before the first frame update
    void Start()
    {
        timer = delayTimer;//we create a timer and put a value we would like (here delayTimer=5 so 5 seconds)
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;// we lower our timer by Time.deltaTime each time Update is called(every frame)
        if (timer <= 0 ) //when timer reaches 0
        {

            //Vector3 carPos = new Vector3(Random.Range(minPosX, maxPosX), transform.position.y, transform.position.z);
            carNo = Random.Range(0,1); // gets number 0 or 1 of array that refers to different vehicles and sets it as carNo
            Instantiate(cars[carNo], transform.position, transform.rotation); //Spawn the selected cars with given position and rotation
            timer = delayTimer;//reset timer


        }
    }
}
