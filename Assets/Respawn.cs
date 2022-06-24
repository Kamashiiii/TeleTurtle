using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Transform pos;
    public float x;
    public float z;
    public float y;




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
        pos.position = new Vector3((float)x, (float)y, (float)z);
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
