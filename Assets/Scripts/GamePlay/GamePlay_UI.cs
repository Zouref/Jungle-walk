using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GamePlay_UI : MonoBehaviour
{
    public static GamePlay_UI instance;
    private void Awake(){
        instance = this;
    }

    private TMP_Text Gold_tx;
    private TMP_Text Health_tx;

    void Start(){
        Gold_tx = GameObject.FindGameObjectWithTag("Gold_tx").GetComponent<TMP_Text>();
        Health_tx = GameObject.FindGameObjectWithTag("Health_tx").GetComponent<TMP_Text>();
        Reffresh_Stats();
    }

    public void Reffresh_Stats(){
        Gold_tx.text = PlayerPrefs.GetFloat("Gold").ToString();
        Health_tx.text = PlayerPrefs.GetFloat("Health").ToString();
    }
}
