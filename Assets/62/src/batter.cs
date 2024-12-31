using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class batter : MonoBehaviour
{
    public GameObject player;
    public Text tex;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Ball") {
            float byou = Random.Range(0.2f, 1.5f);
            StartCoroutine("Swing", byou);
            tex.text = "Hit!!";
        }
    }

    IEnumerator Swing(float byou) {
        // player.transform.rotation = Quaternion.Slerp(player.transform.rotation, Quaternion.Euler(0f, -130f, 0f), 1f);
        anim.Play("batting");
        yield return new WaitForSeconds(byou);
    }
}
