using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtivaTexto : MonoBehaviour {

	public GameObject botao;
	private Texto _texto;

	// Use this for initialization
	void Start () {

		botao.SetActive (false);
		_texto = FindObjectOfType<Texto> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D col){

		if (col.tag == "Player") {
			//StartCoroutine ("Soletrar", txt);
			botao.SetActive (true);
		}
	}

	void OnTriggerExit2D(Collider2D col){

		if (col.tag == "Player") {
			_texto.campoTexto.text = "";
			botao.SetActive (false);
		}
	}


}
