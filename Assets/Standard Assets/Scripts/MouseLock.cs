using UnityEngine;
using System.Collections;

public class MouseLock : MonoBehaviour {


	void Start(){
		Screen.lockCursor = true;

	}
	void Update(){
		Screen.lockCursor = true;
		//Screen.lockCursor = false;
	}

}
