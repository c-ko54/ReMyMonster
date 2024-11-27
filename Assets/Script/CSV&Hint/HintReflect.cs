using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SocialPlatforms;
using TMPro;

public class HintReflect : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI originTextBox;
    public int ID;

    void Start()
    {
        originTextBox.text = "";
        Write(ID);
    }

    //所持ヒントの書き出し
    void Write(int ID)
    {
        if (ID == 0)
        {
            for (int i = 0; i < GameManager.instance.Hint.Length / 2; i++)
            {
                string Hint;
                if (GameManager.instance.GetHint.Contains(i) == true)
                {
                    Hint = GameManager.instance.Hint[i];
                }
                else
                {
                    Hint = "???";
                }

                string ST = i + 1 + "   " + Hint;

                originTextBox.text = originTextBox.text + ST + "\n";
            }

        }
        else//2列目
        {
            for (int i = GameManager.instance.Hint.Length / 2; i < GameManager.instance.Hint.Length; i++)
            {
                string Hint;
                if (GameManager.instance.GetHint.Contains(i))
                {
                    Hint = GameManager.instance.Hint[i];
                }
                else
                {
                    Hint = "???";
                }

                string ST = i + 1 + "   " + Hint;

                originTextBox.text = originTextBox.text + ST + "\n";
            }
        }
    }


}
