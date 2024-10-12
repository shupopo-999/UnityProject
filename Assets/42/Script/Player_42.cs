using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_42 : MonoBehaviour {
	public Rigidbody rb;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// Aキーで左に回る
		if(Input.GetKey(KeyCode.A)){
			transform.Rotate(0f,-5f,0f);
		}
		// Dキーで右に回る
		if(Input.GetKey(KeyCode.D)){
			transform.Rotate(0f,5f,0f);
		}
		// Wキーで前にジャンプする
		if(Input.GetKeyDown(KeyCode.W)){
			rb.AddForce(transform.forward*500f+transform.up*100f);
		}
		// Sキーで後ろにジャンプする
		if(Input.GetKeyDown(KeyCode.S)){
			rb.AddForce(-transform.forward*500f+transform.up*100f);
		}
	}
}
