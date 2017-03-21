using UnityEngine;
using System.Collections;
using Assets.Scripts.Auxiliar.MonoEnums;

public class Spike : MonoBehaviour {

	private Player _player;

	// Use this for initialization
	void Start () 
	{
		_player = FindObjectOfType<Player>();
	}

	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.gameObject.tag == ETagName.Player.GetDescription ()) 
		{
            _player.Die ();
		}
	}
}