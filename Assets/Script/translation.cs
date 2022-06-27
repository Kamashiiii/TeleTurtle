using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class translation : MonoBehaviour
{

    public new Transform transform;
    Vector3 startPos;
    Vector3 pos;
    public bool left = true;
    public bool right = false;
    public bool contact = false;
    GameObject turtle;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        pos = transform.position;
        if (transform.position.x <= 16.75f && right)
        {
            transform.position = new Vector3(pos.x + 0.01f, startPos.y, startPos.z);
            left = false;
        }
        else
            left = true;

        if (transform.position.x >= -0.75f && left)
        {
            transform.position = new Vector3(pos.x - 0.01f, startPos.y, startPos.z);
            right = false;
        }
        else
            right = true;
        if (contact)
            MoveAlong(turtle);
    }
    void OnCollisionEnter(Collision other)
    {
        switch (other.gameObject.tag)
        {
            case "Turtle":
                contact = true;
                turtle = other.gameObject;
                break;
        }
    }
    void OnCollisionExit(Collision other)
    {
        switch (other.gameObject.tag)
        {
            case "Turtle":
                contact = false;
                break;
        }
    }

    void MoveAlong(GameObject turtle)
    {
        if (right)
        {
            turtle.transform.position += new Vector3(0.01f, 0f, 0f);
        }
        if (left)
        {
            turtle.transform.position -= new Vector3(0.01f, 0f, 0f);
        }

    }
}
