using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ONOFF : MonoBehaviour
{
    public int ID;
    [SerializeField] GameObject go;
    public void Start()
    {
        //ID＝1はcpuがボス以外の時
        //「タイトルに戻る」を消して「次へ」を表示する
        if (ID == 1)
        {
            if (GameManager.instance.CPUNUM == 4)
            {
                go.SetActive(false);
            }
            else
            {
                go.SetActive(true);
            }
        }
        //ID＝2はcpuがボスの時
        //「次へ」を消して「タイトルに戻る」を表示する
        if (ID == 2)
        {
            if (GameManager.instance.CPUNUM == 4)
            {
                go.SetActive(true);
            }
            else
            {
                go.SetActive(false);
            }
        }
    }
}
