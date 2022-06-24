using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{

    public GameObject TortueBleu;
    public GameObject TortueRouge;
    public float x;
    public float x2;
    public float z;
    public float z2;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        switch (other.gameObject.tag)
        {
            case "Wall":
                respawn();
                break;
        }
    }

    void respawn()
    {
        TortueRouge.transform.position = new Vector3((float)x, 0, (float)z);
        TortueBleu.transform.position = new Vector3((float)x2, 0, (float)z2);

    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
