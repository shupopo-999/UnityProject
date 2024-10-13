using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bazooka : MonoBehaviour {
    // インクのプレハブの変数
    public GameObject ink;
    
    void Start () {
    	
    }
	
    /**
     * 1.スペースキーが押されたときにインクを自分の位置、向きで作る
     */
    void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(ink, transform.position, transform.rotation);
        }
    }
}
