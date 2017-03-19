using UnityEngine;
using System.Collections;

public class comandoToque : MonoBehaviour {

	private Camera		cam;

    // Use this for initialization
    void Start () {

		cam = GetComponent<Camera> ();
	
	}
	
	// Update is called once per frame
	void Update () {

		// Condiçao abaixo utilizada para sair do jogo utilizando o botao de sair do celular(aquela "flechinha")
		if (Input.GetButtonDown ("Cancel")) {
			Application.Quit();
		}


        //Para cada toque sera utilizada uma variavel touch do tipo Touch
        foreach (Touch touch in Input.touches)
        {
            Ray ray = cam.ScreenPointToRay(touch.position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                GameObject objeto = hit.transform.gameObject;

                switch (touch.phase)
                {

                    case TouchPhase.Began:
                        objeto.SendMessage("Began", SendMessageOptions.DontRequireReceiver);
                        break;

                    case TouchPhase.Ended:
                        objeto.SendMessage("Ended", SendMessageOptions.DontRequireReceiver);
                        break;

                    case TouchPhase.Stationary:
                        objeto.SendMessage("Stationary", SendMessageOptions.DontRequireReceiver);
                        break;

                    case TouchPhase.Moved:
                        objeto.SendMessage("Moved", SendMessageOptions.DontRequireReceiver);
                        break;

                    case TouchPhase.Canceled:
                        objeto.SendMessage("Canceled", SendMessageOptions.DontRequireReceiver);
                        break;
                }
            }
        }
    }
}
