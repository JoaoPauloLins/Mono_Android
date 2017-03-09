using UnityEngine;
using System.Collections;

public class CameraY : MonoBehaviour {


    private Player player;

    public Transform C;
    public Transform B;

    public float speedCam;

    // Use this for initialization
    void Start()
    {

        player = FindObjectOfType(typeof(Player)) as Player;
    }

    // Update is called once per frame
    void Update()
    {

        float y = player.transform.position.y;
        Vector3 posicaoPlayer = new Vector3(transform.position.x, player.transform.position.y, transform.position.z);

        if (y <= C.transform.position.y && y >= B.transform.position.y)
        {

            transform.position = Vector3.Lerp(transform.position, posicaoPlayer, speedCam);
        }

        if (transform.position.y <= C.transform.position.y && transform.position.y >= B.transform.position.y)
        {

            transform.position = Vector3.Lerp(transform.position, posicaoPlayer, speedCam);
        }

    }
}
