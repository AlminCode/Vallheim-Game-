using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	public Animator LeftGateLeftAnim;
	public bool RotateLeft;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter (Collision col)
	{
		RotateLeft=true;
	}
}
