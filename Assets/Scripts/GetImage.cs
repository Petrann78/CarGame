using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetImage : MonoBehaviour
{
    private Sprite img1;
    public Image MyImage;
    // Start is called before the first frame update
    void Start()
    {
        MyImage = GetComponent<Image>();
        //MyImage.AddComponent(typeof(Image));
        //img1 = Resources.Load<Sprite>("stop_sign");
        //MyImage.GetComponent<Image>().sprite = img1;
        //Debug.Log("Get Image script started");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
