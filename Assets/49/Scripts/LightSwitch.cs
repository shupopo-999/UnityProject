using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class LightSwitch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        pointLight.range = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public Light pointLight;
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Player")
        {
            pointLight.range = 100.0f;
        }
    }
}
