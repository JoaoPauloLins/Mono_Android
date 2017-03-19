using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Texto : MonoBehaviour {

	public Text campoTexto;
	public string txt;
	public float espera;

	// Use this for initialization
	void Start () {

		campoTexto.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator Soletrar(string texto){

		int letras = 0;
		campoTexto.text = "";
		while (letras <= texto.Length - 1){
			campoTexto.text += texto[letras];
			letras += 1;
			yield return new WaitForSeconds (espera);
		}
	}

	public void ExecutaSoletrar(){

		StartCoroutine ("Soletrar", txt);
	}
}
