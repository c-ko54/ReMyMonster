using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class NameOut : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI KeyText;

    public void Set()
    {
        int id = StatesManager.instance.PlayerNumber;
        State state = StatesManager.instance.GetPlayerState(id);

        KeyText.text =
            "NAME : " + state.stname + "\n" +
            "TYPE : " + StatesManager.instance.TypeName(state.type) + "\n" +
            "HP : " + state.hp + "\n" +
            "ATK : " + state.atk + "\n" +
            "DEF : " + state.def + "\n" +
            "SPEED : " + state.sp + "\n" +
            "TECHNIC1 : " + StatesManager.instance.ChengeTypeColer(GameConst.tecs[state.Tec1], GameConst.tecsType[state.Tec1]) + "\n" +
            "powwer : " + GameConst.tecsPowwer[state.Tec1] + " " + GameConst.tecsEffect[state.Tec1] + "\n" +
            "TECHNIC2 : " + StatesManager.instance.ChengeTypeColer(GameConst.tecs[state.Tec2], GameConst.tecsType[state.Tec2]) + "\n" +
            "powwer : " + GameConst.tecsPowwer[state.Tec2] + " " + GameConst.tecsEffect[state.Tec2] + "\n" +
            "TECHNIC3 : " + StatesManager.instance.ChengeTypeColer(GameConst.tecs[state.Tec3], GameConst.tecsType[state.Tec3]) + "\n" +
            "powwer : " + GameConst.tecsPowwer[state.Tec3] + " " + GameConst.tecsEffect[state.Tec3];
    }
}
// 文字色変更　"<color=\"red\">NAME : "+ state.stname + "</color>\n"