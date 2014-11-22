using UnityEngine;
using System.Collections;

public class WallHellMove : MonoBehaviour {
	public GameObject Rotate190;
	public GameObject Rotate2280;
	public GameObject Rotate390;
	public GameObject Rotate4280;

	public GameObject Position;

	public GameObject PositionRot90;
	public GameObject PositionRot280;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	//void Update () {
	//	if(Rotate190.transform.rotation.y == PositionRot90.transform.rotation.y && 
		 //  Rotate2280.transform.rotation.y == PositionRot280.transform.rotation.y &&
		//   Rotate390.transform.rotation.y == PositionRot90.transform.rotation.y && 
		//   Rotate4280.transform.rotation.y == PositionRot280.transform.rotation.y ){
		//	float step = 3 * Time.deltaTime;
		//	this.transform.position = Vector3.MoveTowards(this.transform.position,Position.transform.position,step);
		//}
	//}
}
