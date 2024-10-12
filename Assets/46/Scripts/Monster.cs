using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Monster : MonoBehaviour {
    //モンスターにHPとつよさを設定する。
    public int hp;
    public int power;

    //強くなった時に色を変えるために、体のRendererをいれておく変数。
    public Renderer rend;

    //HPとつよさを表示するために、テキストをいれておく変数。
    public Text HPText;
    public Text PowerText;

    //最初はHPが100,つよさが0からはじめる。
	void Start () {
        hp = 100;
        power = 0;
	}

    /* 
     * 1. HPが0で消える
     * 2. つよさが100以上で色が赤くなる
     * 3. ずっとHPテキストの中身をHPにする
     * 4. ずっとつよさテキストの中身をつよさにする
     */
    void Update () {
        if(hp<=0){
            Destroy(gameObject);
        }
        if(power >= 100){
            rend.material.color = Color.red;
        }
        HPText.text = "HP:" + hp;
        PowerText.text = "つよさ:" + power;
	}
    Vector3 scl = new Vector3(0.5f,0.5f,0.5f);
    public void Click()
    {
        transform.localScale += scl;
        hp += 10;
    }
    public void Training()
    {
        transform.localScale -= scl;

        power += 10;
        hp -= 10;
    }


}
