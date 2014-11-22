using UnityEngine;
using System.Collections;

public class ColorBlocks : MonoBehaviour{
	//public ColorBlokcksBlue a;
	// Use this for initialization
	GameObject[] gos;

	
	void Start () {
		gos = GameObject.FindGameObjectsWithTag("ColorB");
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter(Collider other)
	{

		if(other.gameObject.tag=="Player"){
			foreach(GameObject go in gos)
				go.renderer.material.color = Color.blue;

		}


	}
	void OnTriggerExit(Collider other)	{
		if(other.gameObject.tag=="Player"){
			foreach(GameObject go in gos)
				go.renderer.material.color = Color.white;
			
		}
			
	}

}
