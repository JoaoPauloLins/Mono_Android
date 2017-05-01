using UnityEngine;
using System.Collections;
using Assets.Scripts.Auxiliar.MonoEnums;

public class PlataformSlider : MonoBehaviour {

	public bool start;

	// Use this for initialization
	void Start () {

			
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.tag == ETagName.Player.GetDescription())
        {
            col.gameObject.transform.parent = gameObject.transform;
			if (!start){
				start = true;
			}
        }
    }

	void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag == ETagName.Player.GetDescription())
        {
            col.gameObject.transform.parent = null;
        }
    }
}
