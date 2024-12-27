using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_58 : MonoBehaviour
{
    public bool isGoal;
    public Text timeText;

    // Start is called before the first frame update
    void Start()
    {
        isGoal = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0.0f, Input.GetAxis("Mouse X"), 0.0f);
        
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0.0f, 0.0f, 0.03f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0.0f, 0.0f, -0.03f);
        }

        if(transform.position.y <= -5.0f)
        {
            transform.position = new Vector3(0.0f, 0.0f, 0.0f);
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Goal")
        {
            if (!isGoal)
            {
                timeText.text = Time.fixedTime.ToString() + "•b‚ÅGoalI";
            }
            isGoal = true;
        }
    }
}
