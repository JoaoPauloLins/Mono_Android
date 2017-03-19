using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class executaToque : MonoBehaviour {

    private Background _background;
    private Player _player;
    private comandoToque _toque;
	private Texto _texto;

    public	string		nomeBotao;
    public string nomeFases;

    // Use this for initialization
    void Start () {

        _background = FindObjectOfType<Background>();
        _player = FindObjectOfType<Player>();
		_texto = FindObjectOfType<Texto> ();

    }
	
	// Update is called once per frame
	void Update () {

	}

    public void Began()
    {
		if (GameController.currentState == gameState.PLAY){
			switch (nomeBotao)
			{
			case "cor":
				_background.ChangeColor();
				break;

			case "pulo":
				_player.Jump();
				break;

			case "fase":
				SceneManager.LoadScene(nomeFases);
				break;

			case "texto":
				_texto.ExecutaSoletrar ();
				GameController.currentState = gameState.TEXTO;
				break;
			}
		}
		else if (GameController.currentState == gameState.TEXTO) {
			if (nomeBotao == "texto") {
				_texto.campoTexto.text = "";
				GameController.currentState = gameState.PLAY;
			}
		}
    }

    public void Stationary()
    {
		if (GameController.currentState == gameState.PLAY) {
			switch (nomeBotao)
			{
			case "esquerda":
				_player.Walk(-1);
				break;
			case "direita":
				_player.Walk(1);
				break;
			}
		}
    }

    public void Ended()
    {
		if (GameController.currentState == gameState.PLAY) {
			switch (nomeBotao)
			{
			case "esquerda":
				_player.Walk(0);
				break;
			case "direita":
				_player.Walk(0);
				break;
			}
		}
    }

}
