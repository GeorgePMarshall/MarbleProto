using UnityEngine;
using System.Collections;

public class play : MonoBehaviour {
	
	public void ChangeToScene (int sceneToChangeTo) 
	{
		Application.LoadLevel (sceneToChangeTo);
	}
}
