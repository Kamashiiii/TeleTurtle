using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Transform pos;
    Vector3 spawnPos;


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
        }
    }

    void respawn()
    {
        pos.transform.position = spawnPos;
    }
}
