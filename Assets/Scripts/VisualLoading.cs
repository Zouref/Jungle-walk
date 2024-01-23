using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisualLoading : MonoBehaviour
{
   public static VisualLoading instance;
   private void Awake(){
    instance = this;
   }

   public void LoadGame(string s){
      if (s == "GamePlay") ScenesLoader.instance.LoadGame();
   }
}
