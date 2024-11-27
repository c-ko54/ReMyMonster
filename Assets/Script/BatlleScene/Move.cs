using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Move : MonoBehaviour
{
    [SerializeField] private GameObject GO;

    //簡易的な攻撃演出
    public void Attack(int ID)
    {
        var sequence = DOTween.Sequence();
        //1Pの攻撃演出
        if (ID == 1)
        {
            sequence.Append(GO.transform.DOLocalMove(new Vector3(0f, -65f, 0f), 0.5f).SetEase(Ease.Linear));
            sequence.Append(GO.transform.DOLocalMove(new Vector3(-200f, -65f, 0f), 0.5f).SetEase(Ease.Linear));

            sequence.Play();
        }
        //2Pの攻撃演出
        if (ID == 2)
        {
            sequence.Append(GO.transform.DOLocalMove(new Vector3(0f, -65f, 0f), 0.5f).SetEase(Ease.Linear));
            sequence.Append(GO.transform.DOLocalMove(new Vector3(200f, -65f, 0f), 0.5f).SetEase(Ease.Linear));

            sequence.Play();
        }
    }
}
