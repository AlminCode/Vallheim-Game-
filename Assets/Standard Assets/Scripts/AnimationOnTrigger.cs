using UnityEngine;
using System.Collections;

public class AnimationOnTrigger : MonoBehaviour {
	//public GameObject symbol;
	public AnimationClip symbolanim;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player")
			GameObject.Find("symbol").animation.Play ("NOVA");
			

			
			

	}

}
