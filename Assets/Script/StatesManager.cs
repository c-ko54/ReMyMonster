using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;

public class StatesManager : SingletonBehavior<StatesManager>
{
    // Start is called before the first frame update
    public int PlayerNumber = 1;

    private State playerStateOne = null;
    private State playerStateTwo = null;

    void Start()
    {
        ResetPlayerState(1);
        ResetPlayerState(2);
        DontDestroyOnLoad(gameObject);
    }

    public State GetPlayerState(int id)
    {
        if (id == 1)
        {
            return playerStateOne;
        }
        else{
            return playerStateTwo;
        }
    }

    public void ResetPlayerState(int id)
    {
        if (id == 1)
        {
            playerStateOne = new State();
        }
        else{
            playerStateTwo = new State();
        }
    }
    public string TypeName(int type)
    {
        string typename = default;
        if (type == 0)
        {
            typename = "<color=\"red\">Fire</color>";
        }
        if (type == 1)
        {
            typename = "<color=\"green\">Nature</color>";
        }
        if (type == 2)
        {
            typename = "<color=\"blue\">Water</color>";
        }
        if (type == 3)
        {
            typename = "<color=\"yellow\">LIght</color>";
        }
        if (type == 4)
        {
            typename = "<color=\"purple\">Dark</color>";
        }
        if (type == 5)
        {
            typename = "<color=\"grey\">Normal</color>";
        }
        
        return typename;
    }    
    public string ChengeTypeColer(string st,int ColerID)
    {
        string typename = default;
        if (ColerID == 0)
        {
            typename = "<color=\"red\">"+ st +"</color>";
        }
        if (ColerID == 1)
        {
            typename = "<color=\"green\">"+ st +"</color>";
        }
        if (ColerID == 2)
        {
            typename = "<color=\"blue\">"+ st +"</color>";
        }
        if (ColerID == 3)
        {
            typename = "<color=\"yellow\">"+ st +"</color>";
        }
        if (ColerID == 4)
        {
            typename = "<color=\"purple\">"+ st +"</color>";
        }
        if (ColerID == 5)
        {
            typename = "<color=\"grey\">"+ st +"</color>";
        }
        
        return typename;
    }  

}

public class State
{
    public string stname;
    public int hp;
    public int atk;
    public int def;
    public int type;
    public int sp;
    public int Tec1;
    public int Tec2;
    public int Tec3;
    public int image;
}

