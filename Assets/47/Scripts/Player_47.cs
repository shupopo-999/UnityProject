using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_47 : MonoBehaviour {
    
	void Start () {
		
	}
	
    /**
     * 1.ずっと前に動く
     * 2.Aキーが押されたら左に回る
     * 3.Dキーが押されたら右に回る
     */
	void Update () {
        transform.Translate(0f, 0f, 3f * Time.deltaTime);

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0f, -90f * Time.deltaTime, 0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0f, 90f * Time.deltaTime, 0f);
        }
    }
}
