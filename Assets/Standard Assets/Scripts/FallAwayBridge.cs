using UnityEngine;
using System.Collections;

public class FallAwayBridge : MonoBehaviour {

	float triggerDistance = 8f;
	Transform player;

	bool isFalling = false;
	float vel = 0;
	int dir = 1;

	void Update() {
		if(player==null) {
			GameObject go = GameObject.FindGameObjectWithTag("Player");
			if(go == null) 
				return;

			player = go.transform;
		}

		if(!isFalling && Vector3.Distance(player.position, transform.position) <= triggerDistance) {
			isFalling = true;
			if(Random.Range(0,3)==0) {
				//dir = -1;
			}

			Destroy(gameObject, 5f);
		}

	}

	void FixedUpdate() {
		if(isFalling) {
			vel += Physics.gravity.y * Time.deltaTime * dir;

			transform.Translate( Vector3.up * vel * Time.deltaTime );
		}
	}
}
