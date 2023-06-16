using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarDestroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Npc car") //if gameObject that collided with our object has tag of Npc car
        {
            Destroy(col.gameObject);//Destroy Npc car (we put col before gameObject for that, otherwise carDestroyer would be destroyed not Npc car)
        }
    }
}
