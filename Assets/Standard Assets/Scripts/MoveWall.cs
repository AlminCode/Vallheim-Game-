using UnityEngine;
using System.Collections;

public class MoveWall : MonoBehaviour {
	public GameObject cube1;
	public GameObject cube2;
	public GameObject cube3;
	public GameObject cube4;
	//public GameObject Wall;

	//public float a = 200f;
	//Vector3 mypos; 
		// Use this for initialization
	void Start () {
		//mypos =transform.position.y - a;

	}

	void Update () {

			//c1 = true;

			
			if(cube1.transform.rotation.y == cube2.transform.rotation.y && cube3.transform.rotation.y == cube4.transform.rotation.y){
				
				this.transform.Translate(Vector3.up * 30 * Time.deltaTime, Space.World);
				
				

			
		}
	}


		







}
