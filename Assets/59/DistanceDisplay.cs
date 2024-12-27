using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceDisplay : MonoBehaviour
{
    // 飛距離
    public float distance;
    // 飛距離のテキスト
    public Text hikyoriHyouji;
    // 結果のテキスト
    public Text kekkaText;
    public Transform player;
    public Transform goal;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // プレイヤーとゴールの距離を計算する
        distance = Vector3.Distance(player.position, goal.position);
        // 変数distanceの中身を表示するプログラム
        hikyoriHyouji.text = "飛距離：" + distance.ToString();
        if (transform.position.z <= 250.0f)
        {
            kekkaText.text = "どんくらい飛ぶかな？";
        }
        else if(transform.position.z <= 350.0f)
        {
            kekkaText.text = "結構飛んだな！";
        }
        else
        {
            kekkaText.text = "マジか！";
        }
    }
}
