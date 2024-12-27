using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// このプログラムは書きかえないよ！

public class BallUgoki : MonoBehaviour
{
   
    public Rigidbody rb;
    public GameObject cam;
    public bool flag;
    

    
    // Start is called before the first frame update
    void Start()
    {
        flag = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) && flag == true)
        {
            transform.Rotate(-60f*Time.deltaTime, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.S) && flag == true)
        {
            transform.Rotate(60f * Time.deltaTime, 0f, 0f);
        }

        if (Input.GetKeyDown(KeyCode.Space) && flag == true)
        {
            cam.transform.position = transform.position + new Vector3(2f, 3f, -2f);
            cam.transform.rotation = Quaternion.Euler(45f, -45f, 0f);
            rb.AddForce(3000 * transform.forward);
            flag = false;
        }
    }

}
