using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneCaller : MonoBehaviour
{
    public string SceneName;

    void Start(){
      if (SceneName == "BootStrap"){
        BootStrap_Call();
      } else if (SceneName == "Market"){
        Market_Call();
      } else if (SceneName == "MainMenu"){
        MainMenu_Call();
      } else if (SceneName == "Level_0"){
        Level_0_Call();
      }
    }

    public void BootStrap_Call(){

    }

    public void Market_Call(){

    }

    public void MainMenu_Call(){

    }

    public void Level_0_Call(){

    }
}
