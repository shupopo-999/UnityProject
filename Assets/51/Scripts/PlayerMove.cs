using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0f, 0f, 0.15f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0f, 0f, -0.15f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-0.15f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0.15f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(0f,100f,0f);
        }
    }
}
