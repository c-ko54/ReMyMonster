using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoButton : MonoBehaviour
{
    [SerializeField] GameObject obj;
    [SerializeField] BattleManager bm;
    void Start()
    {
        obj.SetActive(false);
    }

    void Update()
    {
        //ターン開始ボタンの設定（1P2P共にわざをえらんでいると現れる）
        if (bm.Standby1P == true && bm.Standby2P == true && bm.selectTime == true)
        {
            obj.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Space) && bm.selectTime == true)
            {
                bm.BattleExecution();
            }
        }
        if(bm.selectTime ==false)
        {
            obj.SetActive(false);
        }

    }
}
