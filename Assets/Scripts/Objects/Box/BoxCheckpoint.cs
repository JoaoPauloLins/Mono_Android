using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxCheckpoint : MonoBehaviour {

    private Vector3 initialPosition;

    // Use this for initialization
    void Start () {

        initialPosition = this.gameObject.transform.position; // salva a posicao inicial da caixa

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void resetPosition()
    { // eh chamada na classe player
        this.gameObject.transform.position = initialPosition;
    }
}
