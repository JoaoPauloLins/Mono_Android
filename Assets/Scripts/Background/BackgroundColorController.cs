using UnityEngine;
using System.Collections;
using Assets.Scripts.Auxiliar.MonoEnums;

public class BackgroundColorController : MonoBehaviour {

    public EColor color;
    private Background _background;
    private SpriteRenderer _spriteRenderer;

    void Start()
    {
        _background = FindObjectOfType<Background>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (color == _background.color)
            _spriteRenderer.enabled = true;
        else
            _spriteRenderer.enabled = false;

    }

}
