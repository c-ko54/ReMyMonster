using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class TecUtils
{
    //ランダムで技のidを返す
    public static int GetRandomTecId()
    {
        int id = UnityEngine.Random.Range(0, GameConst.tecs.Count - 1);

        return id;
    }

    //入力されたidの技名を返す
    public static string GetTecNameById(int id)
    {
        if (id < 0 || id >= GameConst.tecs.Count - GameConst.IrregularTec)
        {
            return string.Empty;
        }

        string tecName = "";
        tecName = GameConst.tecs[id];
        return tecName;
    }

    //入力されたidの技の威力を返す
    public static int GetTecPowerById(int id)
    {
        if (id < 0 || id >= GameConst.tecsPowwer.Count - GameConst.IrregularTec)
        {
            return -1;
        }

        int power = 0;
        power = GameConst.tecsPowwer[id];
        return power;
    }


}
