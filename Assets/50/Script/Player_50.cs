using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_50 : MonoBehaviour
{
    Vector3 startPosition;
    // Use this for initialization
    void Start()
    {
        // スタート位置を保存する
        startPosition = transform.position;
    }

    // Update is called once per frame
    public Rigidbody rb;
    void Update()
    {
        // WASDキーで動く
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0f, 0f, 0.5f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0f, 0f, -0.5f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0.5f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-0.5f, 0f, 0f);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(0f,300f,0f);
        }

        // Y座標が10より小さくなったら(下に落ちたら)スタートの場所へ行く
        if (transform.position.y < -10f)
        {
            transform.position = startPosition;
        }
    }
}
