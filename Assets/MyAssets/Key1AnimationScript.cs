using UnityEngine;
using System.Collections;

public class Key1AnimationScript : MonoBehaviour {

	public Animator Key1;
	bool AnimacijaIsFinished=false;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter(Collider other) {

			Debug.Log (gameObject.name + " OnMouseOver");
		    Key1.SetBool ("Granica", true);
		AnimacijaIsFinished = true;
			
			

	}
}
