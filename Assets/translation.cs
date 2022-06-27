using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class translation : MonoBehaviour
{
    public GameObject tortue;
    public new Transform transform;
    Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Sin(Time.time / 3) * 10, startPos.y, startPos.z);
        /*  if (tortue )
          {
              transform.position = new Vector3(startPos.x, startPos.y, startPos.z);
         }*/
    }
}
