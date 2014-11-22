using UnityEngine;
using System.Collections;

public class CheckPointScript : MonoBehaviour {
	public Transform SpawnPoint;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other)
	{
		//if(other.gameObject.tag == "Player")
//			SpawnPoint.position = new Vector3(transform.position.x,transform.position.y,transform.position.z);
	}
	
}
