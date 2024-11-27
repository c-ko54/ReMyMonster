using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;

public class ExHintWindow : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI KeyText;
    [SerializeField] public GameObject window;
    bool WindowON;
    void Start()
    {
        KeyText.text = "";
        window.transform.localPosition = new Vector3(600f, 0f, 0f);
        WindowON = false;

        //特殊ヒントの有無
        if (GameManager.instance.GetHintEX.Contains(0) == false)
        {
            window.SetActive(false);
        }
        else
        {
            window.SetActive(true);
        }
        ChengeText();
    }

    //取得したヒントの書き出し
    void ChengeText()
    {
        // KeyText.text = KeyText.text + "\n" + i + 1 + GameConst.ExHint[i + 1];
        for (int i = 0; i < GameConst.ExHint.Count; i++)
        {
            KeyText.text = KeyText.text + "\n" + i + 1 + GameConst.ExHint[i];
        }
    }

    //特殊ヒントのウィンドウ動作
    public void OpenWindow()
    {
        if (WindowON == false)
        {
            window.transform.DOLocalMove(new Vector3(200f, 0f, 0f), 0.25f).SetEase(Ease.Linear);
            WindowON = true;
        }
        else
        {
            window.transform.DOLocalMove(new Vector3(600f, 0f, 0f), 0.25f).SetEase(Ease.Linear);
            WindowON = false;
        }
    }
}
