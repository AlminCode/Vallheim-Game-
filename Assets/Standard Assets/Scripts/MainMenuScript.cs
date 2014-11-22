using UnityEngine;
using System.Collections;

public class MainMenuScript : MonoBehaviour {
	public GameObject PlayGame;
	public bool isQuit = false;
	public GameObject ExitGame;
void OnMouseDown()
	{
		if (isQuit) {
			Application.Quit ();
			}
		else {
			//Application.LoadLevel(1);		
		}

		}
	}


