using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Respawn : MonoBehaviour
{
    public GameObject tortue;
    public Transform pos;
    public GameObject porte;
    Vector3 spawnPos;
    Vector3 positionInitiale;
    bool mouvement;


    // Start is called before the first frame update
    void Start()
    {
      
        spawnPos = pos.position;
    }

    void OnCollisionEnter(Collision other)
    {
        switch (other.gameObject.tag)
        {
            case "Wall":
                respawn();
                break;
            case "Button":
                porte.transform.position = new Vector3(0, -50, 0);
                break;
            case "Feu":
                tortue.transform.position = new Vector3(5, 0, -40);
                break;
        }
    }

    void respawn()
    {
        pos.transform.position = spawnPos;
    }
}
