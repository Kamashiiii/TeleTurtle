using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemFloat : MonoBehaviour
{
    public Transform aliment;
    public float x;
    public float y;
    public float z;

    public int y2;
    public bool monte;


    // Start is called before the first frame update
    void Start()
    {
        x = aliment.transform.position.x;
        y = aliment.transform.position.y;
        z = aliment.transform.position.z;

        y2 = 0;
        monte = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (y2 == 0)
            monte = true;
        else if (y2 == 20)
            monte = false;

        if (monte)
            y2 += 1;
        else 
            y2 -= 1;

        aliment.transform.position = new Vector3 ((float)x, (float)y + y2, (float)z);
    }
}
