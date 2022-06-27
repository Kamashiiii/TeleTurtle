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

    }
}