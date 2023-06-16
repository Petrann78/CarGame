using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class carController : MonoBehaviour
{
    public float carSpeed=2;
    public float minPosX = -3.545f;
    public float maxPosX = 0.255f;
    public float minPosY=-8.43f;
    public float maxPosY=1.42f;
    Vector3 position;
   public managerUI ui;
    // Start is called before the first frame update
    void Start()
    {
        //ui = GetComponent<managerUI>();
        position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        position.y += Input.GetAxis("Vertical") * carSpeed * Time.deltaTime;
        //position.y = Mathf.Clamp(position.y, minPosY, maxPosY);
        transform.position = position;
       position.x += Input.GetAxis("Horizontal") * carSpeed * Time.deltaTime;
        position.x = Mathf.Clamp(position.x, minPosX, maxPosX);
        transform.position = position;
    }

    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag == "Npc car")
        {
            Destroy(gameObject);
            ui.gameOver();
        }
       /* if (col.gameObject.tag =="sign")
            SceneManager.LoadScene("MultipleChoiceSceneTemp");
       */
    }

}
