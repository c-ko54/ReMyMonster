using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleBack : MonoBehaviour
{
    [SerializeField]GameObject GO;

    public void Start ()
    {
        GO.SetActive(false);
    }
    public void OnClick()
    {
        GO.SetActive(false);
    }
    void Update()//ESCを押したら表示
    {
        
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            GO.SetActive(true);
        }
    }
}
