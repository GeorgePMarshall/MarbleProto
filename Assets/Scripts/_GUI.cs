using UnityEngine;
using System.Collections;

public class _GUI : MonoBehaviour {

	public float Score = 0;

	public void AddScore(int ScoreToAdd){
		Score += ScoreToAdd;
	}

	void OnGUI(){
		Rect newgui = new Rect (5,5,100,100);
		GUI.skin.label.fontSize = 16;
		GUI.Label(newgui, "Score: " + Score);
	}
}
