using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChanger : MonoBehaviour {
    public MeshRenderer mr;
    public Rigidbody rb;
    public bool flag = false;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Tab))
        {
            flag = !flag;
        }
    }


    void OnCollisionEnter(Collision col)
    {
        if (flag == true)
        {
            if (col.gameObject.name == "InkBall(Clone)")
            {
                mr.material.color = new Color(
                                    Random.Range(0.0f, 1.0f),
                                    Random.Range(0.0f, 1.0f),
                                    Random.Range(0.0f, 1.0f));
            }
        }
        else
        {
            mr.material.color = Color.magenta;
        }
    }
}
