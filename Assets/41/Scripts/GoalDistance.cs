using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalDistance : MonoBehaviour
{
    public float dis;

    public Transform glider;
    public Transform goal;

    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dis = Vector3.Distance(goal.position,glider.position);
        text.text = "ÉSÅ[ÉãÇ‹Ç≈Ç†Ç∆" + dis + "M";
    }
}
