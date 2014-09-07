using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	public Texture background;
	public GUISkin Skin;

	void OnGUI()
	{
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), background);
		if (GUI.Button (new Rect (Screen.width * 0.4f, Screen.height * 0.4f, Screen.width * 0.2f, Screen.height * 0.07f), "Play"))
			Application.LoadLevel ("ChooseVs");
		if (GUI.Button (new Rect (Screen.width * 0.4f, Screen.height * 0.6f, Screen.width * 0.2f, Screen.height * 0.07f), "Quit"))
			Application.Quit();
		GUI.skin = Skin;
		GUI.Label (new Rect (Screen.width * 0.43f, Screen.height * 0.2f, 300f, 200f), "PONG");
	}
}
