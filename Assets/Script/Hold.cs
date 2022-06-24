using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

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
            if (Input.GetMouseButtonDown(1) && GetComponent<Rigidbody>().velocity.magnitude<=0)
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
        GetComponent<ThirdPersonUserControl>().enabled = false;
        GetComponent<animationStateController>().enabled = false;
        GetComponent<Rigidbody>().useGravity = false;
        GetComponent<Transform>().position = holder.position;
        GetComponent<Transform>().parent = holder.parent;
        isHeld = true;
    }
    void turtleThrow()
    {
        GetComponent<Transform>().parent = null;
        GetComponent<ThirdPersonUserControl>().enabled = false;
        GetComponent<animationStateController>().enabled = false;
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<Rigidbody>().AddForce((holder.forward + new Vector3(0, 0.5f, 0)) * throwForce, ForceMode.Impulse);
        isHeld = false;
    }
}