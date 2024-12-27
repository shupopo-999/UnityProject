using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_57 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"),0.0f);
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0.0f, 0.0f, 0.03f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-0.03f, 0.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0.0f, 0.0f, -0.03f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0.03f, 0.0f, 0.0f);
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "beam")
        {
            transform.position = new Vector3(0, 0, 0);
        }
    }
}