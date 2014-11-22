using UnityEngine;
using System.Collections;

public class SymbolAppear : MonoBehaviour {
	public GameObject symbol;
	public GameObject player;
	// Use this for initialization
	void Start () {
		symbol.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player"){
			KretanjeKugle k = other.GetComponent<KretanjeKugle>();
			if(k.brojac >= 2)
				symbol.SetActive(true);	
		}
	}

}
