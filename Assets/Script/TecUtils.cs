using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class TecUtils
{
    public static int GetRandomTecId()
    {
        int id = UnityEngine.Random.Range(0, GameConst.tecs.Count);

        return id;
    }

    public static string GetTecNameById(int id)
    {
        if(id < 0 || id >= GameConst.tecs.Count)
        {
            return string.Empty;
        }

        string tecName = "";
        tecName = GameConst.tecs[id];
        return tecName;
    }

    public static int GetTecPowerById(int id)
    {
        if(id < 0 || id >= GameConst.tecsPowwer.Count)
        {
            return -1;
        }

        int power = 0;
        power = GameConst.tecsPowwer[id];
        return power;
    }

    
}
