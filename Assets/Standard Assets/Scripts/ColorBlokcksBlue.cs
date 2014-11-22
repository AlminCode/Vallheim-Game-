using UnityEngine;
using System.Collections;

public class ColorBlokcksBlue : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void Colorblock(){ 
		if(this.tag == "ColorB"){
		if(this.renderer.material.color != Color.blue)
		this.renderer.material.color = Color.blue;
	}
	}

}
