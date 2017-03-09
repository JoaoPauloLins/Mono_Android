using UnityEngine;
using System.Collections;
using Assets.Scripts.Auxiliar.MonoEnums;

public class Button : MonoBehaviour {

    public bool isPressed;
    public bool IsPressedByPlayer { get; set; }
    public bool IsPressedByBox   { get; set; }

    // Use this for initialization
    void Start()
    {
        IsPressedByPlayer = false;
        IsPressedByBox = false;
        isPressed = false;
    }

    // Update Is called once per frame
    void Update()
    {
        isPressed = (IsPressedByPlayer || IsPressedByBox);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == ETagName.Player.GetDescription())
            IsPressedByPlayer = true;

        if (col.gameObject.tag == ETagName.Box.GetDescription())
            IsPressedByBox = true;
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == ETagName.Player.GetDescription())
            IsPressedByPlayer = false;

        if (col.gameObject.tag == ETagName.Box.GetDescription())
            IsPressedByBox = false;
    }

    public void resetButton()
    {
        IsPressedByBox = false;
        IsPressedByPlayer = false;
        isPressed = false;
    }
}
