using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_61 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A)){
            transform.position = new Vector3(-4.58f,0.85f,-1.7f);
        }
        if(Input.GetKey(KeyCode.S)){
            transform.position = new Vector3(-4.58f,0.85f,0f);
        }
        if(Input.GetKey(KeyCode.D)){
            transform.position = new Vector3(-4.58f,0.85f,1.7f);
        }
    }
}
