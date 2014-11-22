using UnityEngine;
using System.Collections;

public class MainMenuPlayGame : MonoBehaviour {

	public bool isQuit = false;


	void OnMouseDown()
	{

		if (isQuit) {
			Application.LoadLevel(1);
		}
	}
}