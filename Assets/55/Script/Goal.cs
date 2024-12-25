using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public Key key;
    public MeshRenderer color;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (key.flag == true)
        {
            color.material.color = Color.red;
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "Player")
        {
            Destroy(gameObject);
        }
    }
}
