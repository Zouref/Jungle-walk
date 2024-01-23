using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine.Unity;
using Spine;

public class TheAnimation_Sc : StateMachineBehaviour
{
    public string AnimationName;
    public float Speed;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex){
      SkeletonAnimation anim = animator.GetComponent<SkeletonAnimation>();
      anim.state.SetAnimation(1, AnimationName ,true).TimeScale = Speed;
    }
}
