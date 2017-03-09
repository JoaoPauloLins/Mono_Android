using UnityEngine;
using System.Collections;
using Assets.Scripts.Auxiliar.MonoEnums;

public class ColorController : MonoBehaviour {

    public EColor color;
    private Background _background;
    public EColor ActualColor { get; set; }

    void Start()
    {
        _background = FindObjectOfType<Background>();

        //if this object have to exist in both worlds, then the
        //actual color is set to the opposite background color
        if (color == EColor.Both)
            ActualColor = ((_background.color == EColor.White) || (_background.color == EColor.Both)) ? EColor.Black : EColor.White;
        else
            ActualColor = color;
        
    }

    void Update()
    {
        if(color == EColor.Both && ActualColor == _background.color)
            ActualColor = (_background.color == EColor.White) ? EColor.Black : EColor.White;
    }
    
}
