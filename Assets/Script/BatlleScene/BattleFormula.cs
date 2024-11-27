using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class BattleFormula
{
    //ダメージ計算（攻撃側のState,防御側のState,技威力,技のタイプ）、ダメージ値を返す
    public static int damageFomura(State attacker, State Defender, int power, int powertype)
    {
        int atk = attacker.atk;
        int def = Defender.def;
        int atktype = attacker.type;
        int deftype = Defender.type;
        int TurnNum = BattleManager.instance.TurnNum;
        int Cri = UnityEngine.Random.Range(0, 100);

        //ダメージ値の計算
        int damage = 0;
        if (atktype == powertype)
        {
            damage = (power * atk / def);
        }
        else
        {
            damage = (power * atk / def) / 2;
        }


        //タイプ相性の計算
        if (powertype == 0)
        {
            if (deftype == 1 || deftype == 5)
            {
                damage = damage * 2;
            }
            if (deftype == 2 || deftype == 3 || deftype == 4)
            {
                damage = damage / 2;
            }
        }
        if (powertype == 1)
        {
            if (deftype == 2 || deftype == 5)
            {
                damage = damage * 2;
            }
            if (deftype == 0 || deftype == 3 || deftype == 4)
            {
                damage = damage / 2;
            }
        }
        if (powertype == 2)
        {
            if (deftype == 0 || deftype == 5)
            {
                damage = damage * 2;
            }
            if (deftype == 1 || deftype == 3 || deftype == 4)
            {
                damage = damage / 2;
            }
        }
        if (powertype == 3)
        {
            if (deftype == 0 || deftype == 1 || deftype == 2 || deftype == 4)
            {
                damage = damage * 2;
            }
            if (deftype == 5)
            {
                damage = damage / 2;
            }
        }
        if (powertype == 4)
        {
            if (deftype == 0 || deftype == 1 || deftype == 2 || deftype == 3)
            {
                damage = damage * 2;
            }
            if (deftype == 5)
            {
                damage = damage / 2;
            }
        }
        if (powertype == 5)
        {
            if (deftype == 3 || deftype == 4)
            {
                damage = damage * 2;
            }
            if (deftype == 0 || deftype == 1 || deftype == 2)
            {
                damage = damage / 2;
            }
        }

        //ターン数が15ターン以上ならダメージ5倍
        if (TurnNum >= 15)
        {
            damage = damage * 5;
        }
        //ターン数が25ターン以上ならダメージ10倍
        if (TurnNum >= 25)
        {
            damage = damage * 2;
        }
        //ターン数が30ターン以上ならダメージ100固定
        if (TurnNum >= 30)
        {
            damage = 100;
        }

        //ダメージが0以下の時、1にする
        if (damage <= 0)
        {
            damage = 1;
        }

        //クリティカル値が8以下ならダメージ2倍
        if (Cri <= 8)
        {
            damage = damage * 2;
            // BattleManager.instance.CriCheck = true;
        }


        return damage;
    }


    //特定の技の場合効果を与える
    public static void damageEffect(int TecID, State attker)
    {
        if (TecID == 0)
        {
            attker.atk = attker.atk + 20;
        }
        if (TecID == 1)
        {
            attker.hp = attker.hp + 30;
        }
        if (TecID == 2)
        {
            attker.sp = attker.sp + 10;
        }
        if (TecID == 4)
        {
            attker.def = attker.def + 20;
        }
        if (TecID == 12)
        {
            attker.def = attker.def - 15;
            if (attker.def < 1)
            {
                attker.def = 1;
            }
        }
        if (TecID == 13)
        {
            attker.atk = attker.atk - 15;
            if (attker.atk < 1)
            {
                attker.atk = 1;
            }
        }
        if (TecID == 14)
        {
            attker.hp = attker.hp - 15;
        }
        if (TecID == 15)
        {
            attker.hp = attker.hp - 50;
        }
    }
}
