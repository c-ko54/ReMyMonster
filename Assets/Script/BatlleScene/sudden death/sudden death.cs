using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class suddendeath : MonoBehaviour
{
    public Image go;
    public GameObject gm;
    int TurnNum ;

    void Start()
    {
        TurnNum = BattleManager.instance.TurnNum;
        go.color = new Color32(255, 255, 0, 255);
        gm.SetActive(false);
    }
    void Update()
    {
        //ターン数を取得
        TurnNum = BattleManager.instance.TurnNum;

        //25ターンを超えるとgoの文字の色を赤色に
        if (TurnNum >= 25)
        {
            go.color = new Color32(224, 0, 8, 255);
        }

        //30ターンを超えるとgoの文字の色を紫色に
        if (TurnNum >= 30)
        {
            go.color = new Color32(147, 27, 118, 255);
        }
    }

}
