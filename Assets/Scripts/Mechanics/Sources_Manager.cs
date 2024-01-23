using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sources_Manager : MonoBehaviour
{
    public static Sources_Manager instance;
    private void Awake(){
        instance = this;
    }

    public float Gold;

    public void PlusGold(float f){
     Gold = PlayerPrefs.GetFloat("Gold");
     Gold += f;
     PlayerPrefs.SetFloat("Gold", Gold);
    }

    public void MinusGold(float f){
     Gold = PlayerPrefs.GetFloat("Gold");
     Gold -= f;
     PlayerPrefs.SetFloat("Gold", Gold);
    }
}
