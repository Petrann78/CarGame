using UnityEngine;
using UnityEngine.UI;

public class LoadImage : MonoBehaviour
{
	//Texture2D myTexture;
	public string image_name; //= "stop_sign";
	public GameObject myImage;
	public Sprite img1;
	//public GameObject gameObject;

	// Use this for initialization
	void Start()
	{
		// load texture from resource folder
		//ldImage(image_name);

		//new_sprite = Resources.Load<Sprite>("Images/" + image_name);
		//myImage.FromFile("Images/" + image_name);
		//myImage.sprite = new_sprite;
		//GameObject image = GameObject.Find("Image");
		//myImage.GetComponent<Image>().sprite = new_sprite;
		

		//myImage.AddComponent(typeof(Image));
		img1 = Resources.Load<Sprite>("Images/" + image_name); //get sprite with name "image_name" from the Resources and then Images folder.
		
		myImage.GetComponent<Image>().sprite = img1; //sets the sprite property of a image component linked to myImage gameObject equal to img1 sprite 

		
	}
	public void ldImage(string name) {
		
	}
}