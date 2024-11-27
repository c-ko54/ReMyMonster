using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleManager : SingletonBehavior<BattleManager>
{
    [SerializeField] KeyManager keyManager;
    [SerializeField] windowONOFF windowONOFF;
    [SerializeField] DamageWindow damageWindow;
    [SerializeField] GameObject gobutton;
    [SerializeField] windowONOFF windowmanage;
    public State state1 = StatesManager.instance.GetPlayerState(1);
    public State state2 = StatesManager.instance.GetPlayerState(2);

    public bool Standby1P;
    public bool Standby2P;
    public int WindowID;

    public int SelectTec1P;
    public int SelectTec2P;
    public int TurnNum;

    public void Start()
    {
        Standby1P = false;
        Standby2P = false;
        TurnNum = 1;
    }
    public void Update()
    {
        keyManager.TecSelect();
        if (state1.hp <= 0)
        {
            SceneManager.LoadScene("2PResultScene");
        }
        if (state2.hp <= 0)
        {
            SceneManager.LoadScene("1PResultScene");
        }
    }
    public void BattleExecution()
    {

        windowONOFF.WindowON();
        if (state1.sp > state2.sp)
        {
            BattleSystem.Player1BattleExecution(SelectTec1P, this);
            // damageWindow.WindowStart();

            StartCoroutine("MyCoroutine");
            // if (WindowID == 0)
            // {
            //     WindowID = WindowID + 1;
            //     collection.WaitSecond(5);
            // }

            if (state2.hp > 0)
            {
                BattleSystem.Player2BattleExecution(SelectTec2P, this);
                // damageWindow.WindowStart();


                StartCoroutine("MyCoroutine");
                // if (WindowID == 1)
                // {
                //     WindowID = WindowID + 1;
                //     collection.WaitSecond(5);
                // }
            }
        }
        if (state2.sp > state1.sp)
        {
            BattleSystem.Player2BattleExecution(SelectTec2P, this);
            // damageWindow.WindowStart();


            StartCoroutine("MyCoroutine");
            // if (WindowID == 0)
            // {
            //     WindowID = WindowID + 1;
            //     collection.WaitSecond(5);
            // }
            if (state1.hp > 0)
            {
                BattleSystem.Player1BattleExecution(SelectTec1P, this);
                // damageWindow.WindowStart();


                StartCoroutine("MyCoroutine");
                // if (WindowID == 1)
                // {
                //     WindowID = WindowID + 1;
                //     collection.WaitSecond(5);

                // }
            }
        }
        if (state1.sp == state2.sp)
        {
            int Value = Random.Range(0, 2);
            if (Value == 0)
            {
                BattleSystem.Player1BattleExecution(SelectTec1P, this);
                // damageWindow.WindowStart();


                StartCoroutine("MyCoroutine");
                // if (WindowID == 0)
                // {
                //     WindowID = WindowID + 1;
                //     collection.WaitSecond(5);

                // }
                if (state2.hp > 0)
                {
                    BattleSystem.Player2BattleExecution(SelectTec2P, this);
                    // damageWindow.WindowStart();


                    StartCoroutine("MyCoroutine");
                    // if (WindowID == 1)
                    // {
                    //     WindowID = WindowID + 1;
                    //     collection.WaitSecond(5);

                    // }
                }
            }
            else
            {
                BattleSystem.Player2BattleExecution(SelectTec2P, this);
                // damageWindow.WindowStart();


                StartCoroutine("Defeat");
                // if (WindowID == 0)
                // {
                //     WindowID = WindowID + 1;
                //     collection.WaitSecond(5);

                // }
                if (state1.hp > 0)
                {
                    BattleSystem.Player1BattleExecution(SelectTec1P, this);
                    // damageWindow.WindowStart();


                    StartCoroutine("Defeat");
                    // if (WindowID == 1)
                    // {
                    //     WindowID = WindowID + 1;
                    //     collection.WaitSecond(5);
                    // }
                }
            }

        }
        SelectTec1P = -1;
        SelectTec2P = -1;

        windowONOFF.WindowOFF();
        gobutton.SetActive(false);
        WindowID = 0;
        TurnNum++;

        Standby1P = false;
        Standby2P = false;
    }

    IEnumerator Defeat()
    {
        //終わるまで待ってほしい処理を書く
        //例：敵が倒れるアニメーションを開始
        windowmanage.WindowON();

        //5秒待つ
        yield return new WaitForSeconds(5);

        windowmanage.WindowOFF();

        //再開してから実行したい処理を書く
        //例：敵オブジェクトを破壊


    }
}

