using UnityEngine;
using System.Collections;
using Assets.Scripts.Auxiliar.MonoEnums;

public class CheckPoint : MonoBehaviour {
    public int index;
    public Vector3 Position { get; set; }

    public CheckPoint(Vector3 position, int indexAux)
    {
        Position = position;
        index = indexAux;
    }
	// Use this for initialization
	void Start () {
        Position = this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.tag == ETagName.Player.GetDescription())
        {
            Player monoPlayer = FindObjectOfType<Player>();
            if (monoPlayer != null)
                monoPlayer.SetCheckpoint(this);
        }
    }
}
