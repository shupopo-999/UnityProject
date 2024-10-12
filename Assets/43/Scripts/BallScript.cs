using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;
using UnityEngine.UI;

public class BallScript : MonoBehaviour
{
	public int score;
	public int z_score;

	public Text text;
	public Text T_text;
	// Use this for initialization
	void Start()
    {
		z_score = PlayerPrefs.GetInt("zenkai",0);
		T_text.text = "前回のスコア:" + z_score.ToString();
    }

    // Update is called once per frame
    void Update()
	{
		text.text = "あなたのスコア:" + score;
	}

    void OnCollisionEnter(Collision col)
	{
		score++;
		if (col.gameObject.name == "stopper")
		{
			PlayerPrefs.SetInt("zenkai",score);
		}
        
    }
}