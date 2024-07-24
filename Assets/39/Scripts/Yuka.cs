using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yuka : MonoBehaviour {
    public Renderer rend;
	void Start () {
		
	}
	
	void Update () {
        //ずっと回る
        transform.Rotate(0f, 1f, 0f);
	}
    //なにかにぶつかったら、ランダムな色に変わる。
    void OnCollisionEnter(Collision col) {
        rend.material.color = new Color(Random.Range(0f,1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }

}
