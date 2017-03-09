using UnityEngine;
using System.Collections;
using Assets.Scripts.Auxiliar.MonoEnums;

public class BoxFreezer : MonoBehaviour {

    private BoxCollider2D _boxCollider;
    //private BoxCollider2D _triggerCollider;

    // Use this for initialization
    void Start () {
        BoxCollider2D[] colliders = GetComponents<BoxCollider2D>();

        if (colliders[0].isTrigger)
        {
            //_triggerCollider = colliders[0];
            _boxCollider = colliders[1];
        }
        else
        {
            _boxCollider = colliders[0];
            //_triggerCollider = colliders[1];
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.tag == ETagName.Ground.GetDescription() && !_boxCollider.isActiveAndEnabled)
        {
            transform.parent.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionY;
        }
        else// if (_boxCollider.isActiveAndEnabled)
        {
            transform.parent.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
            transform.parent.rotation = new Quaternion(0, 0, 0, 0);
        }

    }
}
