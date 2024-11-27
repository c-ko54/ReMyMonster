using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class windowChenger : SingletonBehavior<windowChenger>
{
    [SerializeField] TextMeshProUGUI KeyText;
    string efectText;
    string CriText;

    //攻撃時のウィンドウに表示する文章の作成
    public void DamageText(State attker, State defence, int ID, int damage)
    {
        if (GameConst.tecsEffect[ID] == "")
        {
            efectText = null;
        }
        else
        {
            efectText = attker.stname + "の" + GameConst.tecsEffect[ID] + GameConst.tecsEffectValue[ID];
        }
        // if (BattleManager.instance.CriCheck == true)
        // {
        //     CriText = "クリティカル！　";
        // }
        // else
        // {
        //     CriText = "";
        // }
        KeyText.text = attker.stname + "の" + GameConst.tecs[ID] + "\n" +
        CriText + defence.stname + "に" + damage + "のダメージ！" + "\n" +
        efectText;
    }
}
