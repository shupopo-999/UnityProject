using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class copy : MonoBehaviour
{
    float t;
    public GameObject obj;
    public int number;

    // Start is called before the first frame update
    void Start()
    {
        t = Time.fixedTime;
    }

    // Update is called once per frame
    void Update()
    {
        number = Random.Range(1,10);
        if (Time.fixedTime - t > 0.2f)
        {
            t = Time.fixedTime;
            if(number <= 6){
                create(new Vector3(-4.58f,6.5f,0f));
            }
            else if(number <= 8){
                create(new Vector3(-4.58f,6.5f,1.7f));
            }
            else if(number <= 9){
                create(new Vector3(-4.58f,6.5f,-1.7f));
            }
        }
    }
    public void create(Vector3 pos)
    {
        //この部分を書いてみよう！！！
        Instantiate(obj,pos,Quaternion.identity);
    }
}
