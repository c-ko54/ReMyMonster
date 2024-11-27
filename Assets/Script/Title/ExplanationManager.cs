using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ExplanationManager : MonoBehaviour
{
    public Sprite[] explanationimage;
    [SerializeField] private GameObject PopUp;
    [SerializeField] TextMeshProUGUI ButtonText;
    private Image image;
    public int ID;

    //説明ウィンドウ
    void Start()
    {
        image = GetComponent<Image>();
        ID = 0;
        image.sprite = explanationimage[ID];
    }

    public void NextButton()//ボタンを押すと次のスライドへ
    {
        ID = ID + 1;
        if (ID >= explanationimage.Length)
        {
            PopUp.SetActive(false);
            ID = 0;
        }
        image.sprite = explanationimage[ID];
    }
    public void ChengeText()//ボタンのテキスト変更
    {
        if (ID <= explanationimage.Length-2)
        {
            ButtonText.text = "NEXT";
        }
        else
        {
            ButtonText.text = "END";
        }
    }


}
