using UnityEngine;
using System.Collections;

public class CameraX : MonoBehaviour {


    private Player player;

    public Transform E;
    public Transform D;

    public float speedCam;

    // Use this for initialization
    void Start()
    {

        player = FindObjectOfType(typeof(Player)) as Player;
    }

    // Update is called once per frame
    void Update()
    {

        float x = player.transform.position.x;
        Vector3 posicaoPlayer = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);

        if (x >= E.transform.position.x && x <= D.transform.position.x)
        {

            transform.position = Vector3.Lerp(transform.position, posicaoPlayer, speedCam);
        }

        if (transform.position.x >= E.transform.position.x && transform.position.x <= D.transform.position.x)
        {

            transform.position = Vector3.Lerp(transform.position, posicaoPlayer, speedCam);
        }

    }
}
