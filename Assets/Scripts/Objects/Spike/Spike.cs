using UnityEngine;
using System.Collections;
using Assets.Scripts.Auxiliar.MonoEnums;

public class Spike : MonoBehaviour {

	private Player _player;
    //private bool _morreu;

	// Use this for initialization
	void Start () 
	{
		_player = FindObjectOfType<Player>();
        //_morreu = false;
	}

	// Update is called once per frame
	void Update () {
        //print("Morreu? " + _morreu);
	}

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.gameObject.tag == ETagName.Player.GetDescription ()) 
		{
            //_morreu = true;
            _player.Die ();
		}
        else
        {
            //_morreu = false;
        }
	}
}