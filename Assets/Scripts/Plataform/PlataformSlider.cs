using UnityEngine;
using System.Collections;
using Assets.Scripts.Auxiliar.MonoEnums;

public class PlataformSlider : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == ETagName.Player.GetDescription())
        {
            col.gameObject.transform.parent = gameObject.transform;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == ETagName.Player.GetDescription())
        {
            col.gameObject.transform.parent = null;
        }
    }
}
