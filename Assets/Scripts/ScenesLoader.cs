using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesLoader : MonoBehaviour
{
    public static ScenesLoader instance;
    private void Awake(){
        instance = this;
    }

    public void LoadMarket(){
      SceneManager.LoadScene("Market");
    }

    public void LoadGame(){
        int x = PlayerPrefs.GetInt("CurrentLevel");
        if (x != null){
         if (x == 0){
           SceneManager.LoadScene("Level_" + x.ToString());
         }
        }
    }
}
