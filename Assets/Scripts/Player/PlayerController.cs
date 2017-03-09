using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    private Background _background;
    private Player _player;

	// Use this for initialization
	void Start ()
    {
        _background = FindObjectOfType<Background>();
        _player = FindObjectOfType<Player>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        KeyboardCalls();
	}

    void KeyboardCalls()
    {
        //Controles no teclado:
        if (Input.GetKeyDown(KeyCode.Z))
            _player.Run(Input.GetAxisRaw("Horizontal"));
        else
            _player.Walk(Input.GetAxisRaw("Horizontal"));

        if (Input.GetAxisRaw("Vertical") == 1 || Input.GetKeyDown(KeyCode.Space))
            _player.Jump();

        if (Input.GetKeyDown(KeyCode.X))
            _background.ChangeColor();

    }

}
