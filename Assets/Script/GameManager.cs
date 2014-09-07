using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	static int playerScore1 = 0;
	static int playerScore2 = 0;

	public GUISkin Skin; 

	public static void Score (string WallName)
		{
			if (WallName == "RightWall")
				{
					playerScore1 += 1;
				}
			else 
				{
					playerScore2 += 1;
				}
		}

	void OnGUI()
	{
		GUI.skin = Skin;
		GUI.Label(new Rect (Screen.width/2-150, 20, 100, 100), "" + playerScore1);
		GUI.Label(new Rect (Screen.width/2+150, 20, 100, 100), "" + playerScore2);
	}
}