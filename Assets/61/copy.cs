using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class copy : MonoBehaviour
{
    float t;
    
    // Start is called before the first frame update
    void Start()
    {
        t = Time.fixedTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.fixedTime - t > 0.2f)
        {
            create();
            t = Time.fixedTime;
        }
    }
    public void create()
    {
        //この部分を書いてみよう！！！
        Instantiate()
    }
}
