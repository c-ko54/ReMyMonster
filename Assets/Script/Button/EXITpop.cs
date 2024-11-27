using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXITpop : MonoBehaviour
{
    [SerializeField] GameObject GO;
    // Start is called before the first frame update

    //escを押した時に現れる
    void Start()
    {
        GO.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            GO.SetActive(true);
        }
    }

}
