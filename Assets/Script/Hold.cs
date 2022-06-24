using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hold : MonoBehaviour
{
    public Transform holder;
    public bool isHeld = false;

    // Update is called once per frame
    void Update()
    {
        if (!GetComponent<animationStateController>().selected)
        {
            if (Input.GetMouseButtonDown(0))
                place();
            if (Input.GetMouseButtonDown(1))
                pickup();
        }
    }

    void pickup()
    {
        GetComponent<Rigidbody>().useGravity = false;
        GetComponent<Transform>().position = holder.position;
        GetComponent<Transform>().parent = holder;
        isHeld = true;
    }
    void place()
    {
        GetComponent<Transform>().parent = null;
        GetComponent<Rigidbody>().useGravity = true;
        isHeld = false;
    }
}
