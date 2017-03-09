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

		//// touchCount contabiliza quatos toques foram dados na tela
		//if (Input.touchCount == 1) {

  //          /*
		//	Esse iria pegar apenas o primeiro toque
		//	Touch touch = Input.touches[0];
		//	*/

  //          Touch firstTouch = Input.touches[0];
  //          Ray fRay = cam.ScreenPointToRay(firstTouch.position);
  //          RaycastHit fHit;

  //          if (Physics.Raycast(fRay, out fHit))
  //          {
  //              GameObject objetoF = fHit.transform.gameObject;

  //              switch (firstTouch.phase)
  //              {
  //                  case TouchPhase.Began:
  //                      objetoF.SendMessage("BeganFirst", SendMessageOptions.DontRequireReceiver);
  //                      break;

  //                  case TouchPhase.Ended:
  //                      objetoF.SendMessage("EndedFirst", SendMessageOptions.DontRequireReceiver);
  //                      break;

  //                  case TouchPhase.Stationary:
  //                      objetoF.SendMessage("StationaryFirst", SendMessageOptions.DontRequireReceiver);
  //                      break;

  //                  case TouchPhase.Moved:
  //                      objetoF.SendMessage("MovedFirst", SendMessageOptions.DontRequireReceiver);
  //                      break;
  //              }
  //          }
  //      }

        //if (Input.touchCount == 2) {

        //    Touch secondTouch = Input.touches[1];
        //    Ray sRay = cam.ScreenPointToRay(secondTouch.position);
        //    RaycastHit sHit;

        //    if (Physics.Raycast(sRay, out sHit))
        //    {
        //        GameObject objetoS = sHit.transform.gameObject;

        //        switch (secondTouch.phase)
        //        {
        //            case TouchPhase.Began:
        //                objetoS.SendMessage("BeganSecond", SendMessageOptions.DontRequireReceiver);
        //                break;

        //            case TouchPhase.Ended:
        //                objetoS.SendMessage("EndedSecond", SendMessageOptions.DontRequireReceiver);
        //                break;

        //            case TouchPhase.Stationary:
        //                objetoS.SendMessage("StationarySecond", SendMessageOptions.DontRequireReceiver);
        //                break;

        //            case TouchPhase.Moved:
        //                objetoS.SendMessage("MovedSecond", SendMessageOptions.DontRequireReceiver);
        //                break;
        //        }
        //    }
        //}


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
