using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChengeColoer : MonoBehaviour
{
    [SerializeField] BattleManager battleManager;
    public int ID;
    public int tecID;
    public GameObject tec;

    void Start()
    {
        //技IDに合わせた技の文字色の変更
        if (tecID == 1)
        {
            ID = GameConst.tecsType[battleManager.state1.Tec1];
        }
        if (tecID == 2)
        {
            ID = GameConst.tecsType[battleManager.state1.Tec2];
        }
        if (tecID == 3)
        {
            ID = GameConst.tecsType[battleManager.state1.Tec3];
        }
        if (tecID == 4)
        {
            ID = GameConst.tecsType[battleManager.state2.Tec1];
        }
        if (tecID == 5)
        {
            ID = GameConst.tecsType[battleManager.state2.Tec2];
        }
        if (tecID == 6)
        {
            ID = GameConst.tecsType[battleManager.state2.Tec3];
        }


        if (ID == 0)
        {
            tec.GetComponent<Image>().color = new Color32(255, 192, 203,255);
        }
        if (ID == 1)
        {
            tec.GetComponent<Image>().color = new Color32(152, 251, 152,255);
        }
        if (ID == 2)
        {
            tec.GetComponent<Image>().color = new Color32(135, 206, 250,255);
        }
        if (ID == 3)
        {
            tec.GetComponent<Image>().color = new Color32(253, 255, 122,255);
        }
        if (ID == 4)
        {
            tec.GetComponent<Image>().color = new Color32(238, 130, 238,255);
        }
        if (ID == 5)
        {
            tec.GetComponent<Image>().color = new Color32(212, 212, 212,255);
        }
    }
}
