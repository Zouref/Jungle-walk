using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void Start_Playing(){
      VisualLoading.instance.LoadGame("GamePlay");
    }
}
