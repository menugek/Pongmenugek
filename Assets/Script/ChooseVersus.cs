using UnityEngine;
using System.Collections;

public class ChooseVersus : MonoBehaviour {

	public Texture background;
	public GUISkin Skin;
	
	void OnGUI()
	{
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), background);
		if (GUI.Button (new Rect (Screen.width * 0.4f, Screen.height * 0.4f, Screen.width * 0.2f, Screen.height * 0.05f), "Vs Player"))
			Application.LoadLevel ("Pong");
		if (GUI.Button (new Rect (Screen.width * 0.4f, Screen.height * 0.6f, Screen.width * 0.2f, Screen.height * 0.05f), "Vs Ia"))
			Application.LoadLevel ("Pong 1");
		if (GUI.Button (new Rect (Screen.width * 0.4f, Screen.height * 0.8f, Screen.width * 0.2f, Screen.height * 0.05f), "Return"))
			Application.LoadLevel ("Menu");
		GUI.skin = Skin;
		GUI.Label (new Rect (Screen.width * 0.43f, Screen.height * 0.2f, 300f, 200f), "PONG");
	}
}
