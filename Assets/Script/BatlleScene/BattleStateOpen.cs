using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BattleStateOpen : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI KeyText;
    [SerializeField] BattleManager battleManager;

    public int id;

    public void Set()//ステータスを表示
    {
        State state1 = battleManager.state1;
        State state2 = battleManager.state2;

        if (id == 1)
        {
            KeyText.text =
            "ATK : " + state1.atk + "\n" +
            "DEF : " + state1.def + "\n" +
            "SPEED : " + state1.sp;
        }
        if (id == 2)
        {
            KeyText.text =
            "ATK : " + state2.atk + "\n" +
            "DEF : " + state2.def + "\n" +
            "SPEED : " + state2.sp;
        }

    }
}
