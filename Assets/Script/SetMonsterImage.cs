using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


//没
public class SetMonsterImage : MonoBehaviour
{
    int ImageNum;

    private Image image;
    public Sprite MonsterImage0;
    public Sprite MonsterImage1;
    public Sprite MonsterImage2;
    public Sprite MonsterImage3;
    public Sprite MonsterImage4;
    public Sprite MonsterImage5;
    public Sprite MonsterImage6;
    public Sprite MonsterImage7;
    public Sprite MonsterImage8;
    public Sprite MonsterImage9;
    public Sprite MonsterImage10;
    public Sprite MonsterImage11;
    public Sprite MonsterImage12;
    public Sprite MonsterImage13;
    public Sprite MonsterImage14;
    public Sprite MonsterImage15;
    public Sprite MonsterImage16;
    public Sprite MonsterImage17;
    public Sprite MonsterImage18;
    public Sprite MonsterImage19;
    public Sprite MonsterImage20;
    public Sprite MonsterImage21;
    public Sprite MonsterImage22;
    public Sprite MonsterImage23;
    public Sprite MonsterImage24;
    public Sprite MonsterImage25;
    public Sprite MonsterImage26;
    public Sprite MonsterImage27;
    public Sprite MonsterImage28;
    public Sprite MonsterImage29;
    public Sprite MonsterImage30;
    public Sprite MonsterImage31;
    public Sprite MonsterImage32;
    public Sprite MonsterImage33;


    
    public void Start()
    {
        image = GetComponent<Image>();

    }

    public void Set()
    {
        image = GetComponent<Image>();

        int id = StatesManager.instance.PlayerNumber;
        State state = StatesManager.instance.GetPlayerState(id);
        
        ImageNum = state.image;

        if(ImageNum == 0){
            image.sprite = MonsterImage0;
        } 
        if(ImageNum == 1){
            image.sprite = MonsterImage1;
        } 
        if(ImageNum == 2){
            image.sprite = MonsterImage2;
        }
        if(ImageNum == 3){
            image.sprite = MonsterImage3;
        } 
        if(ImageNum == 4){
            image.sprite = MonsterImage4;
        } 
        if(ImageNum == 5){
            image.sprite = MonsterImage5;
        }
        if(ImageNum == 6){
            image.sprite = MonsterImage6;
        } 
        if(ImageNum == 7){
            image.sprite = MonsterImage7;
        } 
        if(ImageNum == 8){
            image.sprite = MonsterImage8;
        }
        if(ImageNum == 9){
            image.sprite = MonsterImage9;
        } 
        if(ImageNum == 10){
            image.sprite = MonsterImage10;
        } 
        if(ImageNum == 11){
            image.sprite = MonsterImage11;
        }
        if(ImageNum == 12){
            image.sprite = MonsterImage12;
        } 
        if(ImageNum == 13){
            image.sprite = MonsterImage13;
        } 
        if(ImageNum == 14){
            image.sprite = MonsterImage14;
        }
        if(ImageNum == 15){
            image.sprite = MonsterImage15;
        } 
        if(ImageNum == 16){
            image.sprite = MonsterImage16;
        } 
        if(ImageNum == 17){
            image.sprite = MonsterImage17;
        }
        if(ImageNum == 18){
            image.sprite = MonsterImage18;
        } 
        if(ImageNum == 19){
            image.sprite = MonsterImage19;
        } 
        if(ImageNum == 20){
            image.sprite = MonsterImage20;
        }
        if(ImageNum == 21){
            image.sprite = MonsterImage21;
        } 
        if(ImageNum == 22){
            image.sprite = MonsterImage22;
        } 
        if(ImageNum == 23){
            image.sprite = MonsterImage23;
        }
        if(ImageNum == 24){
            image.sprite = MonsterImage24;
        } 
        if(ImageNum == 25){
            image.sprite = MonsterImage25;
        } 
        if(ImageNum == 26){
            image.sprite = MonsterImage26;
        }
        if(ImageNum == 27){
            image.sprite = MonsterImage27;
        } 
        if(ImageNum == 28){
            image.sprite = MonsterImage28;
        } 
        if(ImageNum == 29){
            image.sprite = MonsterImage29;
        }
        if(ImageNum == 30){
            image.sprite = MonsterImage30;
        } 
        if(ImageNum == 31){
            image.sprite = MonsterImage31;
        } 
        if(ImageNum == 32){
            image.sprite = MonsterImage32;
        }
        if(ImageNum == 33){
            image.sprite = MonsterImage33;
        } 
        // if(ImageNum <= -1 || ImageNum > 34){
        //     image.sprite = ;
        // }
    } 
}
