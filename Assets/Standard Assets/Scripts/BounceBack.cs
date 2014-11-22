

using UnityEngine;

using System.Collections;

public class BounceBack: MonoBehaviour {
	public bool Tbounce=true;
	public float bouncespeed = 5f;
	public Vector3 Position ;      
	public int MinimumBound=28;
	public int MaximumBound=-28;
	bool Moving = true;
	void Start(){
		
		
	}
	void Update(){ 
		if(this.transform.position.z <= MaximumBound || !Moving){
			Moving=false;
			Debug.Log("Naprijed");
			this.Position = Vector3.forward * this.bouncespeed * Time.deltaTime;
			this.transform.Translate(this.Position);        }
		if(this.transform.position.z >= MinimumBound || Moving ){
			Moving=true;
			Debug.Log("Nazad");
			this.Position= Vector3.back * this.bouncespeed * Time.deltaTime;
			this.transform.Translate(this.Position);
			
		}
		
		
		
	}
}

