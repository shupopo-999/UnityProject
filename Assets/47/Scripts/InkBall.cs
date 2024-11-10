using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InkBall : MonoBehaviour {
    public MeshRenderer mr;

    public Rigidbody rb;
	void Start () {
		
	}
	
	/**
     * 1.ずっと前に進む
     */
	void Update () {
        transform.Translate(0f, 0f, 10f * Time.deltaTime);
	}

    /**
     * 1.ふれたら消える
     */
    void OnCollisionEnter(Collision col)
    {
        Destroy(gameObject);

    }
}
