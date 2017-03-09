using UnityEngine;
using System.Collections;
using Assets.Scripts.Auxiliar.MonoEnums;

public class SpriteColorController : MonoBehaviour {

    public EColor color;

    private SpriteRenderer _spriteRenderer;
    private ColorController _parentColorController;
    private Background _background;

	void Start () {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _parentColorController = transform.parent.GetComponent<ColorController>();
        _background = FindObjectOfType<Background>();

    }
	
	// Update is called once per frame
	void Update () {

        //if the respective sprite color are equals to the 
        //actual parent color we activate the sprite
        if (color == _parentColorController.ActualColor && color != _background.color)
        {
            _spriteRenderer.enabled = true;
        }
        else
        {
            _spriteRenderer.enabled = false;
        }
	}
}
