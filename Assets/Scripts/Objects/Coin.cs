using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float Amount = 1;
    private void OnTriggerEnter2D(Collider2D col){
     if (col.gameObject.tag == "Player"){
       Sources_Manager.instance.PlusGold(Amount);
       GamePlay_UI.instance.Reffresh_Stats();
       Destroy(gameObject);
     }
    }
}
