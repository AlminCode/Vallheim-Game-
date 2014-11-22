using UnityEngine;
using System.Collections;

public class GearMovingScript : MonoBehaviour {
	public GameObject Gears;
	public GameObject GearsReplacement;
	public GameObject GearMover;
	public GameObject Gear1;
	public GameObject Gear2;
	bool MouseInputActivated=false;
	// Use this for initialization
	void Start () {
		Gear1.renderer.enabled = false;
		Gear2.renderer.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {

		if (GearMover.animation.isPlaying == false && MouseInputActivated == true) {
			GearMover.renderer.enabled=false;
			Destroy(Gears);
			Gear1.renderer.enabled = true;
			Gear2.renderer.enabled = true;

			GearsReplacement.animation.Play ("Take 001");	
			MouseInputActivated=false;
		}

		}

	void OnMouseOver() {
		if (Input.GetMouseButtonDown (0)) {
			Debug.Log (gameObject.name + " OnMouseOver");
			MouseInputActivated=true;
			GearMover.renderer.enabled=true;
				GearMover.animation.Play ("GearMoverAnimation");


			}
		}

	}

