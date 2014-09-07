using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public KeyCode keyUp;
	public KeyCode keyDown;

	public float speed = 10;
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKey (KeyCode.Escape))
			Application.LoadLevel ("Menu");
		if (Input.GetKey (keyUp)) 
		{
			rigidbody2D.velocity = new Vector2(0, speed);
		} 
		else if (Input.GetKey (keyDown))
		{
			rigidbody2D.velocity = new Vector2(0, speed * -1);
		}
		else 
		{
			rigidbody2D.velocity = new Vector2(0, 0);
		}
	}
}
