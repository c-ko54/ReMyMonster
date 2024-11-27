using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CharaCreate
{
    CreateManager createManager;

    public void SetCreateManager(CreateManager createManager)
    {
        this.createManager = createManager;
    }

    //stnameに応じてステータスを設定する
    //細かな設定は下記のSet〇〇を参照
    public void charaCreate(string stname)
    {
        SoundManager.Instance.PlaySE(SESoundData.SE.summon);
        int id = StatesManager.instance.PlayerNumber;
        State state = StatesManager.instance.GetPlayerState(id);

        state.hp = SetHP(stname);
        state.atk = SetATK(stname);
        state.def = SetDEF(stname);
        state.type = SetTYPE(stname);
        state.sp = SetSP(stname);
        state.Tec1 = TecUtils.GetRandomTecId();
        state.Tec2 = SetTec2(state.Tec1);
        state.Tec3 = SetTec3(state.Tec1, state.Tec2);
        state.image = UnityEngine.Random.Range(0, ImageKeep.instance.Images.Length - ImageKeep.instance.RareImage);

        OriginalNameCheck(state);

    }
    //nameの長さによってHPのランダム値の範囲が決まる
    private int SetHP(string name)
    {
        int hp = 0;
        if (name.Length <= 2)
        {
            hp = UnityEngine.Random.Range(180, 201);
        }
        if (name.Length == 3 || name.Length == 4)
        {
            hp = UnityEngine.Random.Range(200, 221);
        }
        if (name.Length == 5 || name.Length == 6)
        {
            hp = UnityEngine.Random.Range(160, 181);
        }
        if (name.Length == 7 || name.Length == 8)
        {
            hp = UnityEngine.Random.Range(220, 241);
        }
        if (name.Length == 9 || name.Length == 10)
        {
            hp = UnityEngine.Random.Range(240, 301);
        }
        if (name.Length >= 11)
        {
            hp = UnityEngine.Random.Range(100, 151);
        }
        return hp;
    }
    //nameの1文字目によってATKのランダム値の範囲が決まる
    private int SetATK(string name)
    {
        int atk = 0;
        string Name1 = name.Substring(0, 1);

        atk = UnityEngine.Random.Range(20, 121);

        if (Name1 == "a" || Name1 == "i" || Name1 == "u" || Name1 == "e" || Name1 == "o")
        {
            atk = UnityEngine.Random.Range(80, 121);
        }
        if (Name1 == "k" || Name1 == "s")
        {
            atk = UnityEngine.Random.Range(70, 101);
        }
        if (Name1 == "t" || Name1 == "n")
        {
            atk = UnityEngine.Random.Range(60, 81);
        }
        if (Name1 == "h" || Name1 == "m")
        {
            atk = UnityEngine.Random.Range(30, 61);
        }
        if (Name1 == "y" || Name1 == "r")
        {
            atk = UnityEngine.Random.Range(30, 121);
        }
        if (Name1 == "w")
        {
            atk = UnityEngine.Random.Range(80, 151);
        }
        return atk;
    }

    //nameの最後の文字によってDEFのランダム値の範囲が決まる
    private int SetDEF(string name)
    {
        int def = 0;
        int Length = name.Length - 1;
        string namelast = name.Substring(Length, 1);

        def = UnityEngine.Random.Range(30, 121);
        if (namelast == "a" || namelast == "u" || namelast == "e")
        {
            def = UnityEngine.Random.Range(30, 61);
        }
        if (namelast == "f" || namelast == "b" || namelast == "i")
        {
            def = UnityEngine.Random.Range(90, 121);
        }
        if (namelast == "n" || namelast == "c")
        {
            def = UnityEngine.Random.Range(120, 141);
        }
        if (namelast == "y" || namelast == "o" || namelast == "s")
        {
            def = UnityEngine.Random.Range(60, 91);
        }
        return def;
    }

    //nameの中心の文字（文字数が偶数なら前の文字）によってタイプの種類が絞られる
    private int SetTYPE(string name)
    {
        int type = UnityEngine.Random.Range(0, 6);
        int Length = name.Length;
        int nameType = name.Length % 2;
        string middle = "";

        if (Length >= 4)
        {
            if (nameType == 0)
            {
                middle = name.Substring((Length / 2) - 1, 1);
            }
            else
            {
                middle = name.Substring((Length / 2), 1);
            }
        }
        else
        {
            if (Length == 1)
            {
                middle = name.Substring(0, 1);
            }
            if (Length == 2)
            {
                middle = name.Substring(1, 1);
            }
            if (Length == 3)
            {
                middle = name.Substring(1, 1);
            }
        }


        if (middle == "a" || middle == "q")
        {
            type = UnityEngine.Random.Range(2, 4);
        }
        if (middle == "i" || middle == "v")
        {
            type = UnityEngine.Random.Range(3, 5);
        }
        if (middle == "u" || middle == "j")
        {
            type = UnityEngine.Random.Range(4, 6);
        }
        if (middle == "e" || middle == "w")
        {
            type = UnityEngine.Random.Range(1, 3);
        }
        if (middle == "o" || middle == "x")
        {
            type = UnityEngine.Random.Range(0, 2);
        }
        if (middle == "Z" || middle == "p")
        {
            int x = UnityEngine.Random.Range(0, 2);
            if (x == 0)
            {
                type = 5;
            }
            else
            {
                type = 0;
            }

        }
        return type;
    }

//nameの長さによってspのランダム値の範囲が決まる
    private int SetSP(string name)
    {
        int sp = 0;

        // 4 10 16 22 
        // 3 9 15 21 

        if ((name.Length + 1) * 3 % 6 == 0)
        {
            sp = Random.Range(1, 26);
        }
        if ((name.Length + 1) * 3 % 6 == 1)
        {
            sp = Random.Range(25, 51);
        }
        if ((name.Length + 1) * 3 % 6 == 2)
        {
            sp = Random.Range(50, 76);
        }
        if ((name.Length + 1) * 3 % 6 == 3)
        {
            sp = Random.Range(76, 101);
        }
        if ((name.Length + 1) * 3 % 6 == 4)
        {
            sp = Random.Range(1, 151);
        }
        if ((name.Length + 1) * 3 % 6 == 5)
        {
            sp = Random.Range(25, 101);
        }
        return sp;
    }

    private int SetTec2(int Tec1)
    {
        int tec = TecUtils.GetRandomTecId();

        while (tec == Tec1)
        {
            tec = TecUtils.GetRandomTecId();
        }



        return tec;
    }

//技の被りを防ぐ
    private int SetTec3(int Tec1, int Tec2)
    {
        int tec = TecUtils.GetRandomTecId();

        while (tec == Tec1 || tec == Tec2)
        {
            tec = TecUtils.GetRandomTecId();
        }

        return tec;
    }
    
//固有技の設定
    public void OriginalNameCheck(State state)
    {
        if (state.stname == "origin")
        {
            state.type = 3;
            state.Tec3 = 15;
            state.image = 34;
        }
        if (state.stname == "flame" || state.stname == "fire")
        {
            state.type = 0;
        }
        if (state.stname == "adoministrator")
        {
            state.type = 5;
            state.atk = 300;
            state.def = 300;
            state.hp = 750;
            state.Tec2 = 1;
            state.Tec3 = 14;
            state.image = 35;
        }
        if (state.stname == "")
        {
            state.type = 0;
            state.atk = 1;
            state.def = 1;
            state.hp = 1;
            state.Tec1=4;
            state.Tec2 = 6;
            state.Tec3 = 14;
        }
    }
}
