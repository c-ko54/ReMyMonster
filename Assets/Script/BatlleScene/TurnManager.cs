using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TurnManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] BattleManager bm;

    void Start()
    {
        text.text = "Turn : " + bm.TurnNum;
    }

    void Update()
    {
        text.text = "Turn : " + bm.TurnNum;
    }
}
