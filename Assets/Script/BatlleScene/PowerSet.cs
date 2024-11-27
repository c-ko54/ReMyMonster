using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PowerSet : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI KeyText;
    [SerializeField] BattleManager battleManager;
    public int id;
    public int tecID;

    void Start()//技の威力の表示
    {
        //1P側
        if (id == 1)
        {
            if (tecID == 1)
            {
                KeyText.text = "" + GameConst.tecsPowwer[battleManager.state1.Tec1];
            }
            if (tecID == 2)
            {
                KeyText.text = "" + GameConst.tecsPowwer[battleManager.state1.Tec2];
            }
            if (tecID == 3)
            {
                KeyText.text = "" + GameConst.tecsPowwer[battleManager.state1.Tec3];
            }
        }
        else
        {
            //2P側
            if (tecID == 1)
            {
                KeyText.text = "" + GameConst.tecsPowwer[battleManager.state2.Tec1];
            }
            if (tecID == 2)
            {
                KeyText.text = "" + GameConst.tecsPowwer[battleManager.state2.Tec2];
            }
            if (tecID == 3)
            {
                KeyText.text = "" + GameConst.tecsPowwer[battleManager.state2.Tec3];
            }
        }
    }
}
