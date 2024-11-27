using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class suddenDeathText2 : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI KeyText;
    int TurnNum ;
    void Start()
    {
        //「ダメージ5倍」の文字を表示
        TurnNum = BattleManager.instance.TurnNum;
        KeyText.text = "ダメージ5倍！";
    }
    void Update()
    {
        TurnNum = BattleManager.instance.TurnNum;
        //25ターンを超えたら文字を「ダメージ10倍！」に変更
        if (TurnNum >= 25)
        {
            KeyText.text = "ダメージ10倍！";
        }
        if (TurnNum >= 30)
        {
            //30ターンを超えたら文字を「ダメージ100固定！」に変更
            KeyText.text = "ダメージ100固定！";
        }
    }
}

