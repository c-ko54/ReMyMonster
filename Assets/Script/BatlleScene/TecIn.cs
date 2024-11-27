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
    void Start()
    {
        if (id == 1)
        {
            if (tecID == 1)
            {
                KeyText.text = " 1 " + StatesManager.instance.ChengeTypeColer(GameConst.tecs[battleManager.state1.Tec1], GameConst.tecsType[battleManager.state1.Tec1]) + " " + GameConst.tecsEffect[battleManager.state1.Tec1];
            }
            if (tecID == 2)
            {
                KeyText.text = " 2 " + StatesManager.instance.ChengeTypeColer(GameConst.tecs[battleManager.state1.Tec2], GameConst.tecsType[battleManager.state1.Tec2]) + " " + GameConst.tecsEffect[battleManager.state1.Tec2];
            }
            if (tecID == 3)
            {
                KeyText.text = " 3 " + StatesManager.instance.ChengeTypeColer(GameConst.tecs[battleManager.state1.Tec3], GameConst.tecsType[battleManager.state1.Tec3]) + " " + GameConst.tecsEffect[battleManager.state1.Tec3];
            }
        }
        else
        {
            if (tecID == 1)
            {
                KeyText.text = " 1 " + StatesManager.instance.ChengeTypeColer(GameConst.tecs[battleManager.state2.Tec1], GameConst.tecsType[battleManager.state2.Tec1]) + " " + GameConst.tecsEffect[battleManager.state2.Tec1];
            }
            if (tecID == 2)
            {
                KeyText.text = " 2 " + StatesManager.instance.ChengeTypeColer(GameConst.tecs[battleManager.state2.Tec2], GameConst.tecsType[battleManager.state2.Tec2]) + " " + GameConst.tecsEffect[battleManager.state2.Tec2];
            }
            if (tecID == 3)
            {
                KeyText.text = " 3 " + StatesManager.instance.ChengeTypeColer(GameConst.tecs[battleManager.state2.Tec3], GameConst.tecsType[battleManager.state2.Tec3]) + " " + GameConst.tecsEffect[battleManager.state2.Tec3];
            }
        }
    }
}
