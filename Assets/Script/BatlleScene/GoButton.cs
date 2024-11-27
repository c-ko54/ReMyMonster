using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoButton : MonoBehaviour
{
    [SerializeField] GameObject obj;
    [SerializeField]BattleManager bm;
    void Start()
    {
        obj.SetActive(false);
    }

    void Update()
    {
        if(bm.Standby1P == true && bm.Standby2P == true)
        {
            obj.SetActive(true);
        }
    }
}
