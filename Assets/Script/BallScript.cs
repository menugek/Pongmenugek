using UnityEngine;
using System.Collections;

public class BallScript : MonoBehaviour {

	// Use this for initialization
	IEnumerator Start () 
	{
		yield return new WaitForSeconds (2);
		OnBall ();
	}
	
	void Update ()
	{
		var Xvel = rigidbody2D.velocity.x;
		if (Xvel < 18 && Xvel > -18 && Xvel != 0) {
						if (Xvel > 0) {
								rigidbody2D.velocity = new Vector2 (20, rigidbody2D.velocity.y);
						} else {
								rigidbody2D.velocity = new Vector2 (-20, rigidbody2D.velocity.y);
						}
				}
	}

	void OnCollisionEnter2D (Collision2D col) {
		if (col.collider.tag == "Player") 
		{
			var velY = rigidbody2D.velocity.y;
			velY = velY / 2 + col.collider.rigidbody2D.velocity.y / 3;
			rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, velY);
			audio.pitch = Random.Range(0.8f, 1.2f);
			audio.Play();
		}
	}

	public IEnumerator ResetBall()
	{
		rigidbody2D.velocity = new Vector2 (0, 0);
		transform.position = new Vector3 (0, 0, 0);
		yield return new WaitForSeconds (2);
		OnBall ();
	}

	void OnBall()
	{
		var randomnum = Random.Range (0, 9);
		if (randomnum <= 4)
			rigidbody2D.AddForce (new Vector2 (100, 5));
		else
			rigidbody2D.AddForce (new Vector2 (-100, -5));
	}
}
