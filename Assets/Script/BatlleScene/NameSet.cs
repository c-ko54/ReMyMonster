using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NameSet : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI KeyText;
    [SerializeField] BattleManager battleManager;
    public int id;
    void Start()//画像下の名前書き出し
    {
        State state = StatesManager.instance.GetPlayerState(id);
        KeyText.text = StatesManager.instance.ChengeTypeColer(state.stname,state.type);
    }

}
