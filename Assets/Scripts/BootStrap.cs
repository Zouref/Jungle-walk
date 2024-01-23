using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BootStrap : MonoBehaviour
{
    public float Timer;
    private int First;
    // Start is called before the first frame update
    void Start()
    {
        First = PlayerPrefs.GetInt("First");
        if (First != 1){
          FirstPlay();
        }
        StartCoroutine(Starter());
    }

    private void FirstPlay(){
     // Do The Stats For The First Time
     PlayerPrefs.SetFloat("Health", 100f);
     // End Here
     PlayerPrefs.SetInt("First", 1);
    }

    IEnumerator Starter(){
     yield return new WaitForSeconds(Timer);
     SceneManager.LoadScene("MainMenu");
    }
}
