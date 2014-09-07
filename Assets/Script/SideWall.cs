using UnityEngine;
using System.Collections;

public class SideWall : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D hit)
	{
		if (hit.name == "Ball") {
			var WallName = transform.name;
			audio.Play();
			GameManager.Score (WallName);
			hit.gameObject.SendMessage("ResetBall");
		}
	}
}
