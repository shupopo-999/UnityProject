using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_51 : MonoBehaviour
{
     // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, 0f, Input.GetAxis("Vertical") * 0.15f);
        transform.Rotate(0f, Input.GetAxis("Horizontal") * 1.5f, 0f);

        if (transform.position.y < -10f)
        {
            transform.position = new Vector3(0f, 3f, -8f);
        }
    }
}
