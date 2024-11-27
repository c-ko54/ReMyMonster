using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
using JetBrains.Annotations;

public class BattleManager : SingletonBehavior<BattleManager>
{
    [SerializeField] KeyManager keyManager;
    [SerializeField] windowONOFF windowONOFF;
    [SerializeField] DamageWindow damageWindow;
    [SerializeField] GameObject gobutton;
    [SerializeField] windowONOFF windowmanage;
    [SerializeField] windowChenger windowChenger;
    [SerializeField] Move move1;
    [SerializeField] Move move2;
    [SerializeField] GameObject gm;

    public State state1 = StatesManager.instance.GetPlayerState(1);
    public State state2 = StatesManager.instance.GetPlayerState(2);

    public bool Standby1P;
    public bool Standby2P;
    public int WindowID;

    public int SelectTec1P = -1;
    public int SelectTec2P = -1;
    public int TurnNum;
    public bool selectTime;
    public bool HPOK;
    public bool Settlement;
    // public bool CriCheck ;
    public void Start()
    {
        //プレイヤー対戦、CPU戦、ボス戦でBGMを変更する
        if (GameManager.instance.cpuSelect == false)
        {
            SoundManager.Instance.PlayBGM(BGMSoundData.BGM.battle);
        }
        else
        {
            if (GameManager.instance.CPUNUM == 3)
            {
                SoundManager.Instance.PlayBGM(BGMSoundData.BGM.lastbattle);
            }
            else
            {
                SoundManager.Instance.PlayBGM(BGMSoundData.BGM.CPUbattle);
            }

        }

        //プレイヤーのステータスを置き換える
        state1 = StatesManager.instance.GetPlayerState(1);
        state2 = StatesManager.instance.GetPlayerState(2);

        Standby1P = false;
        Standby2P = false;
        HPOK = false;
        TurnNum = 1;
        SelectTec1P = -1;
        SelectTec2P = -1;
        selectTime = true;
        Settlement = false;
  

    }
    public void Update()
    {
        //キー入力関数
        keyManager.TecSelect();

        //15ターン以上になるとサドンデス表示
        if (TurnNum >= 15)
        {
            gm.SetActive(true);
        }
    }
    
    
    //バトルの流れ
    public void BattleExecution()
    {
        windowONOFF.WindowON();
        selectTime = false;


        
        if (state1.sp > state2.sp)//1pの素早さが2pの素早さより高かった時
        {
            //1pの攻撃処理
            Turn1P();

            //攻撃演出＆ターン終了
            var END = DOVirtual.DelayedCall(6, () => TurnEnd());
            var SecondHp = DOVirtual.DelayedCall(5, () => HPCheck1(null, null));
            var Ex2P = DOVirtual.DelayedCall(3, () => Turn2P());

            var FirstHp = DOVirtual.DelayedCall(2, () => HPCheck2(SecondHp, Ex2P));


        }
        if (state2.sp > state1.sp)//2pの素早さが1pの素早さより高かった時
        {
            //2pの攻撃処理
            Turn2P();

            //攻撃演出＆ターン終了
            var END = DOVirtual.DelayedCall(6, () => TurnEnd());
            var SecondHp = DOVirtual.DelayedCall(5, () => HPCheck2(null, null));
            var Ex1P = DOVirtual.DelayedCall(3, () => Turn1P());
            var FirstHp = DOVirtual.DelayedCall(2, () => HPCheck1(SecondHp, Ex1P));
        }
        if (state1.sp == state2.sp)//1pと2pの素早さが同じだった時
        {
            int Value = Random.Range(0, 2);//ランダムで攻撃順序を決定する
            if (Value == 0)
            {
                Turn1P();
                var END = DOVirtual.DelayedCall(6, () => TurnEnd());
                var SecondHp = DOVirtual.DelayedCall(5, () => HPCheck1(null, null));
                var Ex2P = DOVirtual.DelayedCall(3, () => Turn2P());
                var FirstHp = DOVirtual.DelayedCall(2, () => HPCheck2(SecondHp, Ex2P));


            }
            else
            {
                Turn2P();
                var END = DOVirtual.DelayedCall(6, () => TurnEnd());
                var SecondHp = DOVirtual.DelayedCall(5, () => HPCheck2(null, null));
                var Ex1P = DOVirtual.DelayedCall(3, () => Turn1P());
                var FirstHp = DOVirtual.DelayedCall(2, () => HPCheck1(SecondHp, Ex1P));
            }

        }

    }

    //ターン終了処理
    private void TurnEnd()
    {
        SelectTec1P = -1;
        SelectTec2P = -1;


        gobutton.SetActive(false);
        WindowID = 0;
        TurnNum++;
        selectTime = true;
        windowONOFF.WindowOFF();
        Standby1P = false;
        Standby2P = false;
    }
    private void Turn1P()//1pの攻撃処理
    {
        BattleSystem.Player1BattleExecution(SelectTec1P, this);
        move1.Attack(1);
        SoundManager.Instance.PlaySE(SESoundData.SE.Attack);

    }
    private void Turn2P()//2pの攻撃処理
    {
        BattleSystem.Player2BattleExecution(SelectTec2P, this);
        move2.Attack(2);
        SoundManager.Instance.PlaySE(SESoundData.SE.Attack);

    }

    //どちらかのHPが0になった時（2pの攻撃時）
    private void HPCheck2(Tween second, Tween EX)
    {
        if (Settlement == false)
        {
            //1pを先にチェックする
            if (state1.hp <= 0)
            {
                // second.Complete(true);
                // EX.Complete(true);

                if (GameManager.instance.cpuSelect == false)
                {
                    Settlement = true;
                    SceneManager.LoadScene("2PResultScene");
                    Debug.Log("2PWIN");
                }
                else
                {
                    Settlement = true;
                    SceneManager.LoadScene("LoseScene");
                    Debug.Log("YOU LOSE");
                }

            }
            if (state2.hp <= 0)
            {
                // second.Complete(true);
                // EX.Complete(true);
                if (GameManager.instance.cpuSelect == false)
                {
                    Settlement = true;
                    SceneManager.LoadScene("1PResultScene");
                    Debug.Log("1PWIN");
                }
                else
                {
                    if (GameManager.instance.CPUNUM == 4)
                    {
                        Settlement = true;
                        SceneManager.LoadScene("WinCPU");
                        Debug.Log("LAST WIN");
                    }
                    else
                    {
                        Settlement = true;
                        GameManager.instance.CPUNUM = GameManager.instance.CPUNUM + 1;
                        SceneManager.LoadScene("WinCPU");
                        Debug.Log("WIN");

                    }
                }
            }
        }
    }
    
    //どちらかのHPが0になった時（1pの攻撃時）
    private void HPCheck1(Tween second, Tween EX)
    {
        if (Settlement == false)
        {
            //2pを先にチェックする
            if (state2.hp <= 0)
            {

                if (GameManager.instance.cpuSelect == false)
                {
                    Settlement = true;
                    SceneManager.LoadScene("1PResultScene");
                    Debug.Log("1PWIN");
                }
                else
                {
                    if (GameManager.instance.CPUNUM == 4)
                    {
                        Settlement = true;
                        SceneManager.LoadScene("WinCPU");
                        Debug.Log("LAST WIN");
                    }
                    else
                    {
                        Settlement = true;
                        GameManager.instance.CPUNUM = GameManager.instance.CPUNUM + 1;
                        SceneManager.LoadScene("WinCPU");
                        Debug.Log("WIN");

                    }
                }
            }

            if (state1.hp <= 0)
            {


                if (GameManager.instance.cpuSelect == false)
                {
                    Settlement = true;
                    SceneManager.LoadScene("2PResultScene");
                    Debug.Log("2PWIN");
                }
                else
                {
                    Settlement = true;
                    SceneManager.LoadScene("LoseScene");
                    Debug.Log("YOU LOSE");
                }

            }
        }
    }
}