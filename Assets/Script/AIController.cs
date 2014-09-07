using UnityEngine;
using System.Collections;

public class AIController : MonoBehaviour {

	public float speed = 10f;
	public Transform Ball;
	// Update is called once per frame
	void Update () {
		
		if (Ball.rigidbody2D.position.y > rigidbody2D.position.y) 
		{
			rigidbody2D.velocity = new Vector2(0, speed);
		} 
		else if (Ball.rigidbody2D.position.y < rigidbody2D.position.y) 
		{
			rigidbody2D.velocity = new Vector2(0, speed * -1);
		}
		else 
		{
			rigidbody2D.velocity = new Vector2(0, 0);
		}
	}

}
