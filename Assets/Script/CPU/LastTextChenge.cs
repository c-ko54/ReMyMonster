using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LastTextChenge : MonoBehaviour
{
    [SerializeField] Sprite Normal;
    [SerializeField] Sprite Last;
    [SerializeField] private Image image;
    void Start()
    {
        //ラスボス勝利時は特殊勝利画像に変更する
        if (GameManager.instance.CPUNUM == 4)
        {
            image.sprite = Last;
        }
        else
        {
            image.sprite = Normal;
        }
    }


}
