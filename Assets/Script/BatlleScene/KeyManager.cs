using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyManager : MonoBehaviour
{
    int Tec1;
    int Tec2;
    int Tec3;
    int Tec4;
    int Tec5;
    int Tec6;
    public void Start()
    {
        int Tec1 = BattleManager.instance.state1.Tec1;
        int Tec2 = BattleManager.instance.state1.Tec2;
        int Tec3 = BattleManager.instance.state1.Tec3;
        int Tec4 = BattleManager.instance.state2.Tec1;
        int Tec5 = BattleManager.instance.state2.Tec2;
        int Tec6 = BattleManager.instance.state2.Tec3;
    }
    public void TecSelect()
    {
        int Tec1 = BattleManager.instance.state1.Tec1;
        int Tec2 = BattleManager.instance.state1.Tec2;
        int Tec3 = BattleManager.instance.state1.Tec3;
        int Tec4 = BattleManager.instance.state2.Tec1;
        int Tec5 = BattleManager.instance.state2.Tec2;
        int Tec6 = BattleManager.instance.state2.Tec3;
        if (BattleManager.instance.Standby1P == false)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                BattleManager.instance.SelectTec1P = Tec1;
                BattleManager.instance.Standby1P = true;
                Debug.Log("1-1");
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                BattleManager.instance.SelectTec1P = Tec2;
                BattleManager.instance.Standby1P = true;
                Debug.Log("1-2");
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                BattleManager.instance.SelectTec1P = Tec3;
                BattleManager.instance.Standby1P = true;
                Debug.Log("1-3");
            }
        }

        if (BattleManager.instance.Standby2P == false)
        {
            if (Input.GetKeyDown(KeyCode.Keypad1))
            {
                BattleManager.instance.SelectTec2P = Tec4;
                BattleManager.instance.Standby2P = true;
                Debug.Log("2-1");
            }
            if (Input.GetKeyDown(KeyCode.Keypad2))
            {
                BattleManager.instance.SelectTec2P = Tec5;
                BattleManager.instance.Standby2P = true;
                Debug.Log("2-2");
            }
            if (Input.GetKeyDown(KeyCode.Keypad3))
            {
                BattleManager.instance.SelectTec2P = Tec6;
                BattleManager.instance.Standby2P = true;
                Debug.Log("2-3");
            }
        }
    }
}
