using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GetName : MonoBehaviour
{
    [SerializeField] private TMP_InputField inputField;
    public string GetInputName()
    {
        return inputField.text;
        // Debug.Log(inputField.text);
    }
}