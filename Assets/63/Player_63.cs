using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Player_63 : MonoBehaviour
{
    public Text tex;
    public InputField infi;
    //消えるゆかをリストに入れよう
    public List<GameObject> list;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //ここに回答を入力したら動く関数を作ろう！
    public void Answer()
    {
        if(infi.text == "32"){
            Destroy(list[0]);
            infi.text = "";
        }
        if(infi.text == "イルカ"){
            Destroy(list[1]);
            infi.text = "";
        }
    }
}
