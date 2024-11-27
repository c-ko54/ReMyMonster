using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HPset : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI KeyText;
    [SerializeField] BattleManager battleManager;
    public int id;
    void Start()
    {
        if(id == 1)
        {
        KeyText.text = "HP : " + battleManager.state1.hp ;
        // KeyText.text = 
        // "NAME : "+ battleManager.state1.stname + "\n" +
        // "TYPE : "+ battleManager.state1.type + "\n" +
        // "HP : "+ battleManager.state1.hp + "\n" +
        // "ATK : "+ battleManager.state1.atk + "\n" +
        // "DEF : "+ battleManager.state1.def + "\n" +
        // "SKIL : "+ battleManager.state1.sp + "\n" +
        // "TECHNIC1: "+ battleManager.state1.Tec1 + "\n" +
        // "TECHNIC2: "+ battleManager.state1.Tec2 + "\n" +
        // "TECHNIC3: "+ battleManager.state1.Tec3 + "\n";
        }else{
         KeyText.text = "HP : " + battleManager.state2.hp;
        // KeyText.text = 
        // "NAME : "+ battleManager.state2.stname + "\n" +
        // "TYPE : "+ battleManager.state2.type + "\n" +
        // "HP : "+ battleManager.state2.hp + "\n" +
        // "ATK : "+ battleManager.state2.atk + "\n" +
        // "DEF : "+ battleManager.state2.def + "\n" +
        // "SKIL : "+ battleManager.state2.sp + "\n" +
        // "TECHNIC1: "+ battleManager.state2.Tec1 + "\n" +
        // "TECHNIC2: "+ battleManager.state2.Tec2 + "\n" +
        // "TECHNIC3: "+ battleManager.state2.Tec3 + "\n";
        }

    }
    void Update()
    {
                if(id == 1)
        {
        KeyText.text = "HP : " + battleManager.state1.hp;
        // KeyText.text = 
        // "NAME : "+ battleManager.state1.stname + "\n" +
        // "TYPE : "+ battleManager.state1.type + "\n" +
        // "HP : "+ battleManager.state1.hp + "\n" +
        // "ATK : "+ battleManager.state1.atk + "\n" +
        // "DEF : "+ battleManager.state1.def + "\n" +
        // "SKIL : "+ battleManager.state1.sp + "\n" +
        // "TECHNIC1: "+ battleManager.state1.Tec1 + "\n" +
        // "TECHNIC2: "+ battleManager.state1.Tec2 + "\n" +
        // "TECHNIC3: "+ battleManager.state1.Tec3 + "\n";
        }else{
         KeyText.text = "HP : " + battleManager.state2.hp;
        // KeyText.text = 
        // "NAME : "+ battleManager.state2.stname + "\n" +
        // "TYPE : "+ battleManager.state2.type + "\n" +
        // "HP : "+ battleManager.state2.hp + "\n" +
        // "ATK : "+ battleManager.state2.atk + "\n" +
        // "DEF : "+ battleManager.state2.def + "\n" +
        // "SKIL : "+ battleManager.state2.sp + "\n" +
        // "TECHNIC1: "+ battleManager.state2.Tec1 + "\n" +
        // "TECHNIC2: "+ battleManager.state2.Tec2 + "\n" +
        // "TECHNIC3: "+ battleManager.state2.Tec3 + "\n";
        }
    }
}
