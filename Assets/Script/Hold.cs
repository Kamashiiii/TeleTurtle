﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hold : MonoBehaviour
{
    public Transform holder;
    public bool isHeld;
    public float throwForce;
    bool charge;
    public float maxForce;
    public float chargeSpeed;

    // Update is called once per frame
    void Update()
    {
        if (!GetComponent<animationStateController>().selected)
        {
            if (Input.GetMouseButtonDown(0) && isHeld)
                turtleThrow();
            if (Input.GetMouseButtonDown(1))
                pickup();
        }
    }

    void buttonHold()
    {
        charge = true;
    }

    void buttonRelease()
    {
        charge = false;
    }

    void pickup()
    {
        GetComponent<Rigidbody>().useGravity = false;
        GetComponent<Transform>().position = holder.position;
        GetComponent<Transform>().parent = holder;
        isHeld = true;
    }
    void turtleThrow()
    {
        GetComponent<Transform>().parent = null;
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<Rigidbody>().AddForce((holder.forward + new Vector3(0, 0.5f, 0)) * throwForce, ForceMode.Impulse);
        isHeld = false;
    }
}