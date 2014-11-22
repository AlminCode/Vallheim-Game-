using UnityEngine;
using System.Collections;

public class Fireonoff : MonoBehaviour {
	public GameObject flame;
	// Use this for initialization
	void Start () {
		flame.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter()
	{
		flame.SetActive(true);
	}
	void OnTriggerExit()
	{
		flame.SetActive(false);
	}
}
