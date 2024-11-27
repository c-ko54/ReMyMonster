using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandbyScript : MonoBehaviour
{
    [SerializeField] BattleManager battleManager;
    [SerializeField] private GameObject a;
    

    public int ID;

    void Start()
    {
        a.SetActive(false);
    }

    void Update()
    {
        
        if (ID == 1)
        {
            if (battleManager.Standby1P == true)
            {
                a.SetActive(true);
                
            }
            else
            {
                a.SetActive(false);
            }
        }
        if (ID == 2)
        {
            if (battleManager.Standby2P == true)
            {
                a.SetActive(true);
            }
            else
            {
                a.SetActive(false);
            }
        }
    }
}
