using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collection
{

    [SerializeField] DamageWindow damageWindow;
    [SerializeField] windowONOFF windowmanage;
    IEnumerator Defeat()
    {
        //終わるまで待ってほしい処理を書く
        //例：敵が倒れるアニメーションを開始
        windowmanage.WindowON();

        //5秒待つ
        yield return new WaitForSeconds(5);

        windowmanage.WindowOFF();

        //再開してから実行したい処理を書く
        //例：敵オブジェクトを破壊


    }

}