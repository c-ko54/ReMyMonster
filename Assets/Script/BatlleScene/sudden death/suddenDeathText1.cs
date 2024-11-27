using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class suddenDeathText1 : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI KeyText;
    int TurnNum;
    void Start()
    {
        //サドンデスの文字を表示
        TurnNum = BattleManager.instance.TurnNum;
        KeyText.text = "サドンデス";
    }
    void Update()
    {
        TurnNum = BattleManager.instance.TurnNum;
        //25ターンを超えたら文字を「超サドンデス」に変更
        if (TurnNum >= 25)
        {
            KeyText.text = "超サドンデス";
        }

        //30ターンを超えたら文字を「極サドンデス」に変更
        if (TurnNum >= 30)
        {
            KeyText.text = "極サドンデス";
        }
    }
}
