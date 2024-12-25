using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics;

public class Player_54 : MonoBehaviour
{
    public HaneRot hane;
    // Use this for initialization
    void Start()
    {
        hane.flag = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-0.01f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0.01f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0f, 0f, 0.01f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0f, 0f, -0.01f);
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Switch")
        {
            hane.flag = !hane.flag;
        }
    }
}
