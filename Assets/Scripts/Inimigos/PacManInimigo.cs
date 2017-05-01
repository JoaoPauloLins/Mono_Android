using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.Auxiliar.MonoEnums;

public class PacManInimigo : MonoBehaviour {

	private Player _player;
	public MoveInimigo _move;

	// Use this for initialization
	void Start () {

		_player = FindObjectOfType<Player>();
	}
	
	// Update is called once per frame
	void Update () {

		if (_move.destiny.position == _move.A.position) {
			_Flip (1);
		}
		else {
			_Flip (-1);
		}
		
	}

	void OnCollisionEnter2D (Collision2D col){
		if (col.gameObject.tag == ETagName.Player.GetDescription ()) 
		{
			_player.Die ();
		}
	}

	private void _Flip(float direction)
	{
		if(direction != 0) {
			Vector3 theScale = transform.localScale;

			if ((theScale.x < 0 && direction > 0) || (theScale.x > 0 && direction < 0))
				theScale.x *= -1;

			transform.localScale = theScale;

		}

	}
}
