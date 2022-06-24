using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hold : MonoBehaviour
{
    public Transform holder;

    // Update is called once per frame
    void Update()
    {
        /*if (!this.animationStateController.selected)
        {
            if (Input.GetMouseButtonDown(0))
                place();
            if (Input.GetMouseButtonDown(0))
                pickup();
        }*/
    }

    void pickup()
    {
        GetComponent<Rigidbody>().useGravity = false;
        this.transform.position = holder.position;
        //this.transform.parent = GameObject.Find("Holder");
    }
    void place()
    {
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
    }
}
