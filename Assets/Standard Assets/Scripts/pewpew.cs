using UnityEngine;
using System.Collections;

public class pewpew : MonoBehaviour {
	public Rigidbody theBullet;
	public GameObject Player;
	private Plane m_ClickPlane;
	
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Mouse0))
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast(ray, out hit, 100))
			{
				Vector3 dir = (hit.point - Player.transform.position).normalized;
				GameObject fireball = (GameObject)Instantiate (theBullet, Player.transform.position, Quaternion.identity);
				fireball.rigidbody.AddForce( dir * 1000, ForceMode.Impulse);
			}
		}
	}
}
