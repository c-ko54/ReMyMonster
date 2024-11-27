using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class windowONOFF : MonoBehaviour
{
    //攻撃時のウィンドウのONOFF
    [SerializeField] private GameObject a;
    public void WindowON()
    {
        a.SetActive(true);
    } 

    
    public void WindowOFF()
    {
        a.SetActive(false);
    } 
}