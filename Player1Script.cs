using System.Collections;           //C# Code
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player1Script : MonoBehaviour
{
	public Text counttext;
	public Text Wtext;
    private Rigidbody rb;
	private int count;
    public float speed;  //this controls the speed of the player 1

    // Update is called once per frame
    void Start()
    {
        rb = GetComponent<Rigidbody>();
		count = 0;
		SetCountText ();
		Wtext.text = "";
    }
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");  //records input from input on the keyboard
        float moveVertical = Input.GetAxis("Vertical");     //records input from input on the keyboard

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical); //reads input and recognizes them as assigned 
        //0.0f meaning it will not move on the y axis
       
        rb.AddForce(movement * speed);
    }
	void OnTriggerEnter(Collider other) //called when player first touches a trigger coillider( withthe collder being called other or whatever)
	{
		if (other.gameObject.CompareTag ("Pick up")) 
		{

			other.gameObject.SetActive (false);
			count = count + 1;
			SetCountText ();   //calls the function SetCountTEXT to add the number of points for display
		}
		//Destroy(other.gameObject);    		//destroys the colliderg
	}
	void SetCountText ()
	{
		counttext.text = "Count: " + count.ToString ();
		if (count >= 9) 
		{
			Wtext.text = "You Win";
		}
	}
}
