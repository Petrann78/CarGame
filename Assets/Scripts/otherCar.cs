using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class otherCar : MonoBehaviour
{
    public float speed=2f;//we set the speed of the npc cars (relativly slower than the playable car)
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0,1,0) * speed * Time.deltaTime); //we move npc cars in the y axis at the speed we want
    }
}
