using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonterSiCollision : MonoBehaviour
{
    public Transform pos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OuvrirLaPorte()
    {
        for (int i = 0; i < 50; i++)
        {
            float x = pos.position.x;
            float y = pos.position.y;
            float z = pos.position.z;
            pos.position = new Vector3(x, y + 1, z);
        }

    }
}
