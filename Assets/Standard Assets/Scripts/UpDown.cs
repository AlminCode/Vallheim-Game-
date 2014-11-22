using UnityEngine;
using System.Collections;

public class UpDown : MonoBehaviour {

	public float maxupdown = 1;
	public float speed = 50;
	
	float angle = -90;
	float toDegrees = Mathf.PI/180;
	float startHeight;
	
	void Start()
	{
		startHeight = transform.localPosition.y;
	}
	
	void FixedUpdate(){
		float H = transform.localPosition.y;
		angle += speed * Time.deltaTime;
		if (angle > 270) angle -= 360;
		Debug.Log(maxupdown * Mathf.Sin(angle * toDegrees));
		H = startHeight + maxupdown * (1 + Mathf.Sin(angle * toDegrees)) / 2;
	}
}
