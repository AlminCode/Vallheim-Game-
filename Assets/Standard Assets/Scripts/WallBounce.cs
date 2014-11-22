using UnityEngine;
using System.Collections;

public class WallBounce : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "pickto")
		{
			Bounce a = other.GetComponent<Bounce>();
			a.Tbounce=false;
		}

	}
}
