using UnityEngine;
using System.Collections;

public class Play : MonoBehaviour {
	
	public void ChangeToScene (string sceneToChangeTo) 
	{
		Application.LoadLevel (sceneToChangeTo);
	}
}
