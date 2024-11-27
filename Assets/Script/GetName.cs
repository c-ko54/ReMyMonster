using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GetName : MonoBehaviour
{
    [SerializeField] private TMP_InputField inputField;
    //テキストボックスに入力された名前を返す
    public string GetInputName()
    {
        return inputField.text;

    }
}