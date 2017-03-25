using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.Auxiliar.MonoEnums;

public class CircleColliderController : MonoBehaviour {

	public EColor color;

	private CircleCollider2D _circleCollider;
	private ColorController _parentColorController;
	private Background _background;

	// Use this for initialization
	void Start () {
		_circleCollider = GetComponent<CircleCollider2D>();
		_parentColorController = transform.parent.GetComponent<ColorController>();
		_background = FindObjectOfType<Background>();
	}
	
	// Update is called once per frame
	void Update () {

		//if the respective sprite color are equals to the 
		//actual parent color we activate the sprite
		if (((color == _parentColorController.ActualColor) || color == EColor.Both) && color != _background.color)
		{
			_circleCollider.enabled = true;
		}
		else
		{
			_circleCollider.enabled = false;
		}
		
	}
}
