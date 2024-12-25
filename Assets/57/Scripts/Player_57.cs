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
            transform.Translate(0.0f, 0.0f, 0.01f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-0.01f, 0.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0.0f, 0.0f, -0.01f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0.01f, 0.0f, 0.0f);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "beam")
        {
            transform.position = new Vector3(0, 0, 0);
        }
    }
}