using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pitcher : MonoBehaviour
{
    public Rigidbody rb;
    public Slider sl;
    public Vector3 pos;
    bool flag;
    // Start is called before the first frame update
    void Start()
    {
        flag = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space)&& flag){
            rb.AddForce(pos.x,pos.y,sl.value);
            flag = false;
        }
    }
    void OnCollisionEnter(Collision col){
        if(col.gameObject.name == "Pitcher"){
            flag = true;
        }
    }
}