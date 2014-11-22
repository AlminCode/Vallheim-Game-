using UnityEngine;
using System.Collections;

public class Interaction : MonoBehaviour {


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
			

	}

	public void OnMouseEnter(){
		Debug.Log ("enter");

	}
	public void OnMouseOver(){
		if(Input.GetMouseButtonDown(0)){
			transform.Rotate(new Vector3(0,30,0));}
		Debug.Log ("rotate");
	}
	


}
