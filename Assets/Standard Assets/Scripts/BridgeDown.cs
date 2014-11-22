using UnityEngine;
using System.Collections;

public class BridgeDown : MonoBehaviour {
	public GameObject bridge;
	public bool lol = false;
	public GameObject player;
	Transform target;
	public GameObject bridgePosition;
//	float smooth = 0.5f;
	int speed = 5;
	public float bouncespeed = 5f;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	if(lol == true){
			float step = 3 * Time.deltaTime;
			//this.Position = Vector3.forward * this.bouncespeed * Time.deltaTime;
			//bridge.transform.position = bridgePosition.transform.position;
			bridge.transform.position = Vector3.MoveTowards(bridge.transform.position,bridgePosition.transform.position,step);
			//lol = false;

		}
	}
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player"){
		KretanjeKugle k = other.GetComponent<KretanjeKugle>();
		if(k.brojac >= 2)
				lol=true;
	}

}
				                           }
