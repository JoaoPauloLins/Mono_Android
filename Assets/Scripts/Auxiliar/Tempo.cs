using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tempo : MonoBehaviour {

	public Text campoTexto;

	private float segundos = 0;
	private float minutos = 5;
	private bool isRunning = true;

	// Use this for initialization
	void Start () {

		
	}
	
	// Update is called once per frame
	void Update () {

		if (isRunning){
			
			if (segundos <= 0){
				minutos -= 1;
				segundos = 59;
			}

			if (segundos <= 9){
				campoTexto.text = "0" + Mathf.RoundToInt(minutos).ToString() + ":0" + Mathf.RoundToInt(segundos).ToString();
			}
			else{
				campoTexto.text = "0" + Mathf.RoundToInt(minutos).ToString() + ":" + Mathf.RoundToInt(segundos).ToString();
			}


			if (segundos > 0){
				segundos -= Time.deltaTime;
			}

			if (minutos <= 0 && segundos <= 0) {
				isRunning = false;
			}
		}
		
	}
}
