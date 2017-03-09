using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class executaToque : MonoBehaviour {

    private Background _background;
    private Player _player;
    private comandoToque _toque;

    public	string		nomeBotao;
    public string nomeFases;

    // Use this for initialization
    void Start () {

        _background = FindObjectOfType<Background>();
        _player = FindObjectOfType<Player>();

    }
	
	// Update is called once per frame
	void Update () {

	}

	//public void BeganFirst(){
	//	switch (nomeBotao) {
	//	case "cor":
 //               _background.ChangeColor();
	//		    break;

 //           case "pulo":
 //               _player.Jump();
 //               break;
	//	}
	//}

 //   public void EndedFirst(){
	//	switch (nomeBotao) {
	//	case "esquerda":
 //               _player.Walk(0);
 //               break;
	//	case "direita":
 //               _player.Walk(0);
 //               break;
	//	}
	//}

 //   public void StationaryFirst(){
	//	switch (nomeBotao) {
	//	case "esquerda":
 //               _player.Walk(-1);
	//		    break;
	//	case "direita":
 //               _player.Walk(1);
	//		    break;
	//	}
	//}

 //   public void BeganSecond()
 //   {
 //       switch (nomeBotao)
 //       {
 //           case "cor":
 //               _background.ChangeColor();
 //               break;

 //           case "pulo":
 //               _player.Jump();
 //               break;
 //       }
 //   }

    public void Began()
    {
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
        }
    }

    public void Stationary()
    {
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

    public void Ended()
    {
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
