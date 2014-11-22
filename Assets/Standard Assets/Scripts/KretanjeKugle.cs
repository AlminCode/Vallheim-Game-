using UnityEngine;
using System.Collections;

public class KretanjeKugle : MonoBehaviour {
	public float brzinaKretanja = 100;
	public int brojac=2;
	public GUIText pobjeda;
	public GUIText Zivoti;
	public int Lifes=3;
	public GUIText brojactext;
	private SpecialB p;

	void Start(){
		brojac=0;
		//brojacPoena();
//		pobjeda.text="";
		
	}
	void Update()
	{

	
	}


	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag == "symbol")
		{
			other.gameObject.SetActive(false);
			brojac++;
			//brojacPoena();
		}

			
	}


	//void brojacPoena(){
	//	brojactext.text="Symbols: " + brojac.ToString () + "/2";
	//	Zivoti.text="Zivoti: " + Lifes.ToString();
	//	if(brojac >=8)
		//	pobjeda.text="Pobjedili ste";


	//}
}
