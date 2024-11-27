using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstTitleBack : MonoBehaviour
{
    public GameObject GO;

    void Start()
    {
        GO.SetActive(false);
    }
    public void OnClick()
    {
        GO.SetActive(true);
    }
        public void OnCanselClick()
    {
        GO.SetActive(false);
    }
}
