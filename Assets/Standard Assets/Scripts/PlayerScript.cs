using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	public Collider currentCheckPoint;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void PlayerDied() {
		
		this.transform.position = currentCheckPoint.gameObject.transform.position;
		
	}
}
