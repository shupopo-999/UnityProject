using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_45 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0.0f,0.0f,0.3f);

        if (Input.GetKeyDown(KeyCode.D))
        {
            Invoke("Right", 1.0f);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            Invoke("Left", 1.0f);
        }
    }

    // 壁にぶつかったらスタートにもどるプログラム
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "Wall")
        {
            transform.position = new Vector3(0f, 0f, 0f);
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
    }
    void Right()
    {
        transform.Rotate(0.0f, 90.0f, 0.0f);
    }
    void Left()
    {
        transform.Rotate(0.0f, -90.0f, 0.0f);
    }
}
