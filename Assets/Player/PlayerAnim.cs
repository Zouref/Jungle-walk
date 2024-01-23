using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine;
using Spine.Unity;

public class PlayerAnim : MonoBehaviour
{
    public static PlayerAnim instance;
    private void Awake(){
      instance = this;
    }

    public Animator Anim;


    public void Idle(){
      Anim.SetFloat("Running", -1f);
    }

    public void Run(){
      Anim.SetFloat("Running", 1f);
    }

    public void Jump(){
      Anim.Play("Jump");
    }

    public void Attack(int i){

    }

    public void Diffence(){
        
    }

    public void Die(){

    }
}
