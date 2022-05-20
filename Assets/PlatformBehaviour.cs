using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlatformBehaviour : MonoBehaviour
{
    public float speed;
    public bool toRight;
    public GameObject cDer;
    public GameObject cIzq;
    public GameObject toqueDer;
    public GameObject toqueIzq;
    int yOffset=1;
    // Start is called before the first frame update


    void Start()
    {
        toRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (toRight /*==true*/)
        {
            transform.position += new Vector3(speed, 0, 0);
        }
        else
        {
            transform.position += new Vector3(-speed, 0, 0);
        }



        if (transform.position.x > cDer.transform.position.x - 1)
        {
            toRight = false;
            GameObject clon;
            clon = Instantiate(toqueDer);
            clon.transform.position = cDer.transform.position + new Vector3(0, yOffset, 0);
        }
        else if (transform.position.x < cIzq.transform.position.x + 1)
        {
            toRight = true;
            GameObject clon;
            clon = Instantiate(toqueIzq);
            clon.transform.position = cIzq.transform.position + new Vector3(0, yOffset, 0);
            yOffset++;
        }


    }
}
