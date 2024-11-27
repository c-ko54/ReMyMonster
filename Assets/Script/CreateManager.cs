using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateManager : MonoBehaviour
{
    [SerializeField] GetName getName;
    

    CharaCreate charaCreate;    
    // Start is called before the first frame update
    void Start()
    {
        charaCreate = new CharaCreate();
        charaCreate.SetCreateManager(this);
    }

    // Update is called once per frame
    public void CreateExecution()
    {
        int id = StatesManager.instance.PlayerNumber;
        State state = StatesManager.instance.GetPlayerState(id);

        state.stname = getName.GetInputName();
        
        if(state.stname.Length <= 0)
        {
            Debug.Log("What your name?");
        }
        else
        {
            charaCreate.charaCreate(state.stname);
            Debug.Log("name " + state.stname);
            Debug.Log("hp " + state.hp);
            Debug.Log("atk " + state.atk);
            Debug.Log("def " + state.def);
            Debug.Log("type " + state.type);
            Debug.Log("sp " + state.sp);
            Debug.Log("Tec1 " + state.Tec1);
            Debug.Log("Tec2 " + state.Tec2);
            Debug.Log("Tec3 " + state.Tec3);
        }

    }
}



