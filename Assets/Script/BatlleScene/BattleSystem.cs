using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class BattleSystem
{
    //1pが攻撃したときの攻撃処理＆追加効果処理
    public static void Player1BattleExecution(int ID, BattleManager battleManager)
    {

        battleManager.state2.hp = battleManager.state2.hp - BattleFormula.damageFomura(battleManager.state1, battleManager.state2, GameConst.tecsPowwer[ID], GameConst.tecsType[ID]);
        Debug.Log("2P damage = " + BattleFormula.damageFomura(battleManager.state1, battleManager.state2, GameConst.tecsPowwer[ID], GameConst.tecsType[ID]));
        BattleFormula.damageEffect(ID, battleManager.state1);
        Debug.Log("1Pの" + GameConst.tecsEffect[ID] + GameConst.tecsEffectValue[ID]);
        windowChenger.instance.DamageText(battleManager.state1,battleManager.state2,ID,BattleFormula.damageFomura(battleManager.state1, battleManager.state2, GameConst.tecsPowwer[ID], GameConst.tecsType[ID]));
        if (battleManager.state2.hp <= 0)
        {
            battleManager.state2.hp = 0;
        }
    }

    //2pが攻撃したときの攻撃処理＆追加効果処理
    public static void Player2BattleExecution(int ID, BattleManager battleManager)
    {
        battleManager.state1.hp = battleManager.state1.hp - BattleFormula.damageFomura(battleManager.state2, battleManager.state1, GameConst.tecsPowwer[ID], GameConst.tecsType[ID]);
        Debug.Log("1P damage = " + BattleFormula.damageFomura(battleManager.state2, battleManager.state1, GameConst.tecsPowwer[ID], GameConst.tecsType[ID]));
        BattleFormula.damageEffect(ID, battleManager.state2);
        Debug.Log("2Pの" + GameConst.tecsEffect[ID] + GameConst.tecsEffectValue[ID]);
        windowChenger.instance.DamageText(battleManager.state2,battleManager.state1,ID,BattleFormula.damageFomura(battleManager.state2, battleManager.state1, GameConst.tecsPowwer[ID], GameConst.tecsType[ID]));
        if (battleManager.state1.hp <= 0)
        {
            battleManager.state1.hp = 0;
        }
    }
}
