using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameConst
{
    public static int IrregularTec = 1;
    public static List<string> tecs = new List<string>()
    {
        "Burning","Bubble","Wind","BlackLight","Light","RollingStone","Inferno","Earthquake","RainStorm","Sunshine","DarkMatter","Megaton","GoldenWind","Judgment","GigaBurst","Primitive"
    };

    public static List<int> tecsPowwer = new List<int>()
    {
        10,5,10,15,10,20,40,40,40,30,30,35,60,60,70,150
    };

    public static List<int> tecsType = new List<int>()
    {
        0,2,1,4,3,5,0,1,2,3,4,5,1,3,5,3
    };
    public static List<string> tecsEffect = new List<string>()
    {
        "atk↑","HP↑↑","sp↑","","def↑","","","","","","","","def↓","atk↓","hp↓","hp↓↓↓"
    };

    public static  List<int> tecsEffectValue = new List<int>()
    {
        20,30,10,0,20,0,0,0,0,0,0,0,15,15,15,50
    };

    public static List<string> ExHint = new List<string>()
    {
        "「Origin」と入力するとタイプと専用技を取得できる！" + "\n" + "タイプ：light"+ "\n" + "固有技：Primitive【光】　　"+ "\n" +"威力150（自身のHP-50）"+ "\n", 
    };


}
