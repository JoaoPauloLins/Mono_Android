using UnityEngine;
using System.Collections;
using Assets.Scripts.Auxiliar.MonoEnums;

public class Background : MonoBehaviour {
    public EColor color;

    // Use this for initialization
    void Start () {
        if (color == EColor.Both)
        {
            color = EColor.White;
        }
            
    }
	
	// Update is called once per frame
	void Update () {

        //if (color == EColor.White)
        //{
        //    print("Fundo Branco");
        //}
        //else if(color == EColor.Black)
        //{
        //    print("Fundo Preto");
        //}
        
	}

    //this function change the background color to the opposite color
    public void ChangeColor()
    {
        color = (color == EColor.White) ? EColor.Black : EColor.White;
    }

    public EColor GetColor()
    {
        return color;
    }
}
