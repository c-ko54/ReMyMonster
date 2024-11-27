using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanselPop : MonoBehaviour
{
    [SerializeField] GameObject GO;
    //表示させる
    public void Onclick()
    {
        GO.SetActive(false);
    }
}
