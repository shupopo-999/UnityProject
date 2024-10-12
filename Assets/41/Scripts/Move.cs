using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0.0f,0.0f,0.5f);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(0.0f,900.0f,0.0f);
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.transform.name == "Ground")
        {
            rb.AddForce(0.0f,2000.0f,-8000.0f);
        }
    }
}
