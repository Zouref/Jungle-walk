using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player instance;
    private void Awake(){
        instance = this;
    }

    public float Health;

    public void PlusHealth(float f){
        Health = PlayerPrefs.GetFloat("Health");
        Health += f;
        if (Health > 100f) Health = 100f;
        PlayerPrefs.SetFloat("Health", Health);
        GamePlay_UI.instance.Reffresh_Stats();
    }

    public void MinusHealth(float f){
      Health = PlayerPrefs.GetFloat("Health");
      Health -= f;
      if (Health <= 0f){
       PlayerPrefs.SetFloat("Health", 0f);
       GamePlay_UI.instance.Reffresh_Stats();
       DieNow();
      } else {
        PlayerPrefs.SetFloat("Health", Health);
        GamePlay_UI.instance.Reffresh_Stats();
      }
    }

    public void DieNow(){
      // Player Dies
    }
}
