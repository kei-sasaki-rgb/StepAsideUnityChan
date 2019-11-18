using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyController: MonoBehaviour {

    //Unityちゃんのオブジェクト
    private GameObject unitychan;
    //Unityちゃんとカメラの距離
    private float difference;

    // Use this for initialization
    void Start () {
        //Unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");
        //Unityちゃんとカメラの位置（z座標)の差を求める
        this.difference = unitychan.transform.position.z - this.transform.position.z;
    }

    // Update is called once per frame
    void Update () {

        //画面外に出たらオブジェクトを破棄する
        if (this.transform.position.z < unitychan.transform.position.z)
        Destroy(this.gameObject);
    }
}
