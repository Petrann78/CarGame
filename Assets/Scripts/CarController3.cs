using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarController3 : MonoBehaviour
{
	public managerUI ui;
	public float move, moveSpeed, rotation, rotationSpeed;
	public float minPosX = -3.545f;
	public float maxPosX = 0.255f;
	
	
	void Start()
    {
		moveSpeed = 5f;// this variable represents the speed which we like our car to be travelling vertically( up and down)
		rotationSpeed = 100f; //this variable represents the speed which we like our car to be rotating (cars rarely move left to right without rotation)
    }

	void Update()
    {
		move = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;//basicaly we get the vertical input and we multiply it by the variable movespeed and Time.deltaTime
		rotation = Input.GetAxis("Horizontal") * -rotationSpeed * Time.deltaTime; // we get the horizontal input and multiply it by rotationSpeed anad Time.deltaTime 
		

	}

	private void LateUpdate()
    {
		transform.Translate(0f, move, 0f); //here we make the car move up and down when up or down arrow is pressed x,z axis are 0 because we want the car to move only horizontaly
		if (move != 0)//car should not rotate while it is not moving
        {
			transform.Rotate(0f, 0f, rotation); //make car rotate left and right when left/right arrows are pressed y,z axis is 0 because we want the car only to rotate 
		}
		

    }

	void OnCollisionEnter2D(Collision2D col)
    {
		if (col.gameObject.tag == "Npc car")//when car collides with GameObject that has the tag Npc car, destroy playable car and call gameOver method
		{
			Destroy(gameObject);
			//ui.Pause();
			ui.gameOver();
			
		}

    }
}