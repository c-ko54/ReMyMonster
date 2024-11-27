using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;
using System.IO;

public class CPUCreate : SingletonBehavior<CPUCreate>
{
    [SerializeField] GameObject CPUImage;
    CharaCreate charaCreate = new CharaCreate();
    public int ID = 0;
    void Start()
    {
        SoundManager.Instance.PlayBGM(BGMSoundData.BGM.none);

        //プレイヤー２に作成する
        StatesManager.instance.PlayerNumber = 2;

        //名前リストからランダムに名前を選択する
        ID = Random.Range(0, NameManager.instance.names.Length - 1);
        GameManager.instance.CPUID = ID;


        State state = StatesManager.instance.GetPlayerState(2);

        //ラスボスの時は名前を固定
        if (GameManager.instance.CPUNUM == 3)
        {
            state.stname = "origin";
        }
        else
        {
            state.stname = NameManager.instance.names[ID];
        }

        //名前からステータスを作成する
        if (GameManager.instance.CPUNUM == 3)
        {
            charaCreate.charaCreate("origin");
        }
        else
        {
            charaCreate.charaCreate(NameManager.instance.names[ID]);
        }


        //出現演出＆シーン以降
        DOVirtual.DelayedCall(2, () => move());
        DOVirtual.DelayedCall(5, () => SceneManager.LoadScene("GoBattleScene"));
    }

    //出現演出作成
    private void move()
    {
        CPUImage.transform.DOLocalMove(new Vector3(0f, 0f, 0f), 0.1f).SetEase(Ease.Linear);
        SoundManager.Instance.PlaySE(SESoundData.SE.don);
    }
}
