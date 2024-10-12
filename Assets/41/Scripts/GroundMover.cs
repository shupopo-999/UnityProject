using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMover : MonoBehaviour {
    Vector3 speed;
    float zikan;
    // Start is called before the first frame update
    void Start () {
        // 動く速さをランダムにする
        speed.x = Random.Range (-10f, 10f);
        speed.y = Random.Range (-10f, 10f);
        speed.z = Random.Range (-10f, 10f);
    }

    // Update is called once per frame
    void Update () {
        transform.Translate (speed * Time.deltaTime);

        // 5秒ごとに進む方向を逆にする
        if (Time.fixedTime - zikan > 5f) {
            speed = -speed;
            zikan = Time.fixedTime;
        }
    }
}