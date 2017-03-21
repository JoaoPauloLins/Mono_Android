using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaoIndicadora : MonoBehaviour {

	public GameObject mao;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		if (GameController.currentState == gameState.PLAY) {
			mao.SetActive (true);
		}
		else {
			mao.SetActive (false);
		}
		
	}
}
