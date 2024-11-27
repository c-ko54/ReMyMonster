using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public static class BattleFormula
{
    public static int damageFomura(State attacker ,State Defender ,int power ,int powertype)
    {
        int atk = attacker.atk;
        int def = Defender.def;
        int atktype = attacker.type;
        int deftype = Defender.type;


        int damage = 0;
        if (atktype == powertype)
        {
            damage =  (power * atk/def) * 2;
        }else{
            damage =   (power * atk/def);
        }

        if(powertype == 0)
        {
            if(deftype == 1 || deftype == 5)
            {
                damage = damage * 2;
            }
            if (deftype == 2 || deftype == 3 || deftype == 4)
            {
                damage = damage / 2;
            }
        }
        if(powertype == 1)
        {
            if(deftype == 2 || deftype == 5)
            {
                damage = damage * 2;
            }
            if (deftype == 0 || deftype == 3 || deftype == 4)
            {
                damage = damage / 2;
            }
        }
        if(powertype == 2)
        {
            if(deftype == 0 || deftype == 5)
            {
                damage = damage * 2;
            }
            if (deftype == 1 || deftype == 3 || deftype == 4)
            {
                damage = damage / 2;
            }
        }
        if(powertype == 3)
        {
            if(deftype == 0 || deftype == 1 || deftype ==2 || deftype == 4)
            {
                damage = damage * 2;
            }
            if (deftype == 5)
            {
                damage = damage / 2;
            }
        }
        if(powertype == 4)
        {
            if(deftype == 0 || deftype == 1 || deftype ==2 || deftype == 3)
            {
                damage = damage * 2;
            }
            if (deftype == 5)
            {
                damage = damage / 2;
            }
        }
        if(powertype == 5)
        {
            if(deftype == 3 || deftype == 4)
            {
                damage = damage * 2;
            }
            if (deftype == 0 || deftype ==1 || deftype ==2)
            {
                damage = damage / 2;
            }
        }
        return damage;
    }

    public static void damageEffect(int TecID,State attker)
    {
        if(TecID == 0)
        {
            attker.atk = attker.atk + 20;
        }
        if(TecID == 1)
        {
            attker.hp = attker.hp +30;
        }
        if(TecID == 2)
        {
            attker.sp = attker.sp + 10;
        }
        if(TecID == 4)
        {
            attker.def = attker.def + 20;
        }
        if(TecID ==12)
        {
            attker.def =attker.def - 15;
        }
        if(TecID == 13)
        {
            attker.atk = attker.atk -15;
        }
        if(TecID ==14)
        {
            attker.hp = attker.hp-15;
        }
    }
}
