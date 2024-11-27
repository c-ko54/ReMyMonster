using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HintTexxtChenge : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI KeyText;
    public int ID;
    public State enemy = StatesManager.instance.GetPlayerState(2);
    public int enemyID;

    void Start()
    {
        //ID＝1ならヒントのタイトル
        if (ID == 1)
        {
            KeyText.text = enemy.stname + "'s Hint";

        }

        //ID＝2ならヒント文
        if (ID == 2)
        {
            //ラスボスなら個別ヒント
            if (enemy.stname == "origin")
            {
                KeyText.text = "名前を「origin」にすると…？";
                if (GameManager.instance.GetHintEX.Contains(1) == false)
                {
                    //コレクションにヒント文追加
                    GameManager.instance.GetHintEX.Add(0);
                }
            }
            else
            {
                //CPUIDに応じたヒントを表示
                KeyText.text = GameManager.instance.Hint[GameManager.instance.CPUID];

                //コレクションにヒント文追加
                GameManager.instance.GetHint.Add(GameManager.instance.CPUID);
            }
        }
    }
}