using UnityEngine;
using System.Collections;

public class MovePlataform : MonoBehaviour {

    public float speed;
    public GameObject plataform;
    public Transform A;
    public Transform B;
    public Transform destiny;
    private int rote;

    // Use this for initialization
    void Start()
    {

        rote = 0;
        plataform.transform.position = A.position;
        destiny.position = B.position;

    }

    // Update is called once per frame
    void Update()
    {

        float step = speed * Time.deltaTime;
        plataform.transform.position = Vector3.MoveTowards(plataform.transform.position, destiny.position, step);

        if (plataform.transform.position == destiny.position)
        {

            //StartCoroutine(wait());

            switch (rote)
            {

                case 0:
                    destiny.position = A.position;
                    rote = 1;
                    break;
                case 1:
                    destiny.position = B.position;
                    rote = 0;
                    break;
            }

        }

    }

    IEnumerator wait()
    {
        float aux = speed;
        speed = 0;
        yield return new WaitForSeconds(1);
        speed = aux;
    }
}
