using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TecIn : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI KeyText;
    [SerializeField] BattleManager battleManager;
    public int id;
    public int tecID;

    //技名＆技威力＆割り当てボタンの表示
    void Start()
    {
        //1P側
        if (id == 1)
        {
            if (tecID == 1)
            {
                KeyText.text = " Z " + GameConst.tecs[battleManager.state1.Tec1] + " " + GameConst.tecsEffect[battleManager.state1.Tec1];
            }
            if (tecID == 2)
            {
                KeyText.text = " X " + GameConst.tecs[battleManager.state1.Tec2] + " " + GameConst.tecsEffect[battleManager.state1.Tec2];
            }
            if (tecID == 3)
            {
                KeyText.text = " C " + GameConst.tecs[battleManager.state1.Tec3] + " " + GameConst.tecsEffect[battleManager.state1.Tec3];
            }
        }
        else//2P側
        {
            if (tecID == 1)
            {
                KeyText.text = " 1 " + GameConst.tecs[battleManager.state2.Tec1] + " " + GameConst.tecsEffect[battleManager.state2.Tec1];
            }
            if (tecID == 2)
            {
                KeyText.text = " 2 " + GameConst.tecs[battleManager.state2.Tec2] + " " + GameConst.tecsEffect[battleManager.state2.Tec2];
            }
            if (tecID == 3)
            {
                KeyText.text = " 3 " + GameConst.tecs[battleManager.state2.Tec3] + " " + GameConst.tecsEffect[battleManager.state2.Tec3];
            }
        }
    }
}
