using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class cleaChengeBuck : MonoBehaviour
{
    [SerializeField]Image GO;

    void Start()
    {
        //ボスを倒した時、背景をだんだん元に戻す
        if (GameManager.instance.CPUNUM == 4)
        {
           Color color = gameObject.GetComponent<Image>().color;
           GO.DOFade(0f, 2f).SetEase(Ease.Linear);
        }
    }
    
}
