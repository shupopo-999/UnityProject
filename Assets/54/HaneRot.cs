using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HaneRot : MonoBehaviour
{
    [SerializeField]public bool flag = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (flag == true)
        {
            transform.Rotate(0, 0.1f, 0);
        }
    }
}
