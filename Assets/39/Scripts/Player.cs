using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 vec;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0.0f, -1.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0.0f, 1.0f, 0.0f);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.forward * 100f + transform.up * 300f);
        }
        if (-3.0f > transform.position.y)
        {
            transform.position = vec;
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Yuka")
        {
            vec = col.transform.position;
        }
    }
}
