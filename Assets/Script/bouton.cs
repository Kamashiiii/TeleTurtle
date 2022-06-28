using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bouton : MonoBehaviour
{

    public GameObject porte;
    public bool boutonActive;

    // Start is called before the first frame update
    void Start()
    {
        boutonActive = false; 
    }
    
    void OnCollisionEnter(Collision other)
    {
        switch (other.gameObject.tag)
        {
            case "Turtle":
                boutonActive = true;
                break;
        }
    }

    void OnCollisionExit(Collision other)
    {
        switch (other.gameObject.tag)
        {
            case "Turtle":
                boutonActive = false; 
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (boutonActive)
            porte.GetComponent<AN_DoorScript>().isOpened = true;
        else
            porte.GetComponent<AN_DoorScript>().isOpened = false;
    }
}
