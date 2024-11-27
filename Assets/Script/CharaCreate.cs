using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaCreate
{
    CreateManager createManager;

    public void SetCreateManager(CreateManager createManager)
    {
        this.createManager = createManager;
    }

    public void charaCreate(string stname)
    {
        int id = StatesManager.instance.PlayerNumber;
        State state = StatesManager.instance.GetPlayerState(id);
        
        state.hp = SetHP(stname);
        state.atk = SetATK(stname);
        state.def = SetDEF(stname);
        state.type = SetTYPE(stname);
        state.sp = SetSP(stname);
        state.Tec1 = TecUtils.GetRandomTecId();
        state.Tec2 = TecUtils.GetRandomTecId();
        if (state.Tec2 == state.Tec1)
        {
            state.Tec2 = TecUtils.GetRandomTecId();
        }
        state.Tec3 = TecUtils.GetRandomTecId();
        if (state.Tec3 == state.Tec1 || state.Tec3 == state.Tec2)
        {
            state.Tec3 = TecUtils.GetRandomTecId();
        }
        state.image = UnityEngine.Random.Range(0,34);   
    }

    private int SetHP(string name)
    {
        int hp = 0;
        if(name.Length <= 3)
        {
            Debug.Log("3");
            hp = UnityEngine.Random.Range (180, 201);
        }
       if(name.Length == 4)
        {
            Debug.Log("4");
            hp = UnityEngine.Random.Range (200,221);
        }
        if(name.Length == 5)
        {
            Debug.Log("5");
            hp = UnityEngine.Random.Range (160,181);
        }
        if(name.Length == 6)
        {
            Debug.Log("6");
            hp = UnityEngine.Random.Range (220,241);
        }
        if(name.Length == 7)
        {
            Debug.Log("7");
            hp = UnityEngine.Random.Range (240,301);
        }
        if(name.Length >= 8)
        {
            Debug.Log("8");
            hp = UnityEngine.Random.Range (100,151);
        }
        return hp;
    }
    private int SetATK(string name)
    {
        int atk = 0;

        if(name.Length <= 3)
        {
            atk = UnityEngine.Random.Range (100,121);
        }
       if(name.Length == 4)
        {
            atk = UnityEngine.Random.Range (40,61);
        }
        if(name.Length == 5)
        {
            atk = UnityEngine.Random.Range (60,81);
        }
        if(name.Length == 6)
        {
            atk = UnityEngine.Random.Range (20,41);
        }
        if(name.Length == 7)
        {
            atk = UnityEngine.Random.Range (1,121);
        }
        if(name.Length >= 8)
        {
            atk = UnityEngine.Random.Range (80,151);
        }
        return atk;
    }

    private int SetDEF(string name)
    {
        int def = 0;

        if(name.Length % 4 == 0)
        {
            def = UnityEngine.Random.Range (30,61);
        }
       if(name.Length % 4 == 1)
        {
            def = UnityEngine.Random.Range (90,121);
        }
        if(name.Length % 4 == 2)
        {
            def = UnityEngine.Random.Range (120,140);
        }
        if(name.Length % 4 == 3)
        {
            def = UnityEngine.Random.Range (60,91);
        }
        return def;
    }
    private int SetTYPE(string name)
    {
        int type =0;

        if(name.Length * 10 % 6 == 0)
        {
            type = UnityEngine.Random.Range (2,4);
        }
       if(name.Length * 10 % 6 == 1)
        {
            type = UnityEngine.Random.Range (3,5);
        }
        if(name.Length * 10 % 6 == 2)
        {
            type = UnityEngine.Random.Range (4,6);
        }
        if(name.Length * 10 % 6 == 3)
        {
            type = UnityEngine.Random.Range (1,3);
        }
        if(name.Length * 10 % 6 == 4)
        {
            type = UnityEngine.Random.Range (0,2);
        }
        if(name.Length * 10 % 6 == 5)
        {
            type = UnityEngine.Random.Range (5,7);
        }
        return type;
    }

    private int SetSP(string name)
    {
        int sp =0;

        if(name.Length * 3 % 6 == 0)
        {
            sp = Random.Range(1,26);
        }
       if(name.Length * 3 % 6 == 1)
        {
            sp = Random.Range(25,51);
        }
        if(name.Length * 3 % 6 == 2)
        {
            sp = Random.Range(50,76);
        }
        if(name.Length * 3 % 6 == 3)
        {
            sp = Random.Range(76,101);
        }
        if(name.Length * 3 % 6 == 4)
        {
            sp = Random.Range(1,151);
        }
        if(name.Length * 3 % 6 == 5)
        {
            sp = Random.Range(25,101);
        }
        return sp;
    }
        
}
