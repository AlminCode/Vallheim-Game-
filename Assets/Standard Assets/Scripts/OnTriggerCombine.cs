using UnityEngine;
using System.Collections;

public class OnTriggerCombine : MonoBehaviour {
	public GameObject Position;
	public GameObject Bridge1;
	public GameObject Bridge2;
	bool test = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(test == true){
			float step = 3 * Time.deltaTime;
		Bridge1.transform.position = Vector3.MoveTowards(Bridge1.transform.position,Position.transform.position,step);
		Bridge2.transform.position = Vector3.MoveTowards(Bridge2.transform.position,Position.transform.position,step);
		}
	}
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player"){
			test = true;
		}
	}
}
