using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_55 : MonoBehaviour
{ 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0f, 0f, 0.01f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0f, 0f, -0.01f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0f, -0.18f, 0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0f, 0.18f, 0f);
        }

    }
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "Ghost")
        {
            transform.position = new Vector3(-20f,0.5f,-12f);
        }
    }

}
