using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemFloat : MonoBehaviour
{
    public Transform aliment;
    public float x;
    public float y;
    public float z;
    float yRotate;
    float rotation;


    // Start is called before the first frame update
    void Start()
    {
        x = aliment.transform.position.x;
        y = aliment.transform.position.y;
        z = aliment.transform.position.z;


    }

    // Update is called once per frame
    void Update()
    {
        float timer = Time.time;

        aliment.transform.position = new Vector3(x, y + (Mathf.Sin(3*timer)/2), z);
        aliment.transform.Rotate(0f,Time.deltaTime*50f,0f,Space.Self);
    }
}
