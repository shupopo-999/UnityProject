using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//プレイヤー用のスクリプト。さわらないでね！
public class Player_43 : MonoBehaviour {

	public FixedJoint fj;
	public Rigidbody rb;
	bool hasshaShita;
	// Use this for initialization
	void Start () {
		hasshaShita = false;
	}
	
	// Update is called once per frame
	void Update () {

			//Aキーで左に、Dキーで右にうごく
		if (Input.GetKey (KeyCode.D) && transform.position.x < 12f) {
				transform.Translate (0.4f, 0f, 0f);
			}
		if (Input.GetKey (KeyCode.A) && transform.position.x > -12f) {
				transform.Translate (-0.4f, 0f, 0f);
			}
		
		//スペースキーではっしゃ
		if (Input.GetKeyDown (KeyCode.Space) && hasshaShita == false) {
			hasshaShita = true;
			fj.breakForce = 0f;
			rb.AddForce (0f,-2300f,0f);
		}
			
	}
}
