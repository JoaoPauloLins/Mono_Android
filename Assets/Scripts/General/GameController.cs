using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum gameState{
	PAUSE, PLAY, TEXTO
}

public class GameController : MonoBehaviour {

	public static gameState currentState;

	// Use this for initialization
	void Start () {

		currentState = gameState.PLAY;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
