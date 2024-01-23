using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    // Movment
    public float Speed = 5f;
    public Vector2 vct;
    private FixedJoystick joy;

    // Jump
    public float jumpForce = 700f;
    private bool isGrounded = true;
    private Rigidbody2D rb;
    private bool JumpPress;

    // Variable For Animations
    private bool Walking, Resting, Jumping;

    void Start(){
        joy = GameObject.FindGameObjectWithTag("Joy").GetComponent<FixedJoystick>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update(){
        vct.x = joy.Horizontal;
        
        if (vct.x == 0.00f){
          PlayerAnim.instance.Idle();
        } else {
          if (isGrounded) PlayerAnim.instance.Run();
        }

        if (joy.Horizontal > 0){
          transform.localScale = new Vector2(1,1);
        }

        if (joy.Horizontal < 0f ){
          transform.localScale = new Vector2(-1,1);
        }

        transform.Translate(vct * Speed * Time.deltaTime);

        if (JumpPress && isGrounded)
        {
            rb.AddForce(new Vector2(0, jumpForce));
            JumpPress = false;
        }
    }

    public void JumpNow(){
      PlayerAnim.instance.Jump();
      StartCoroutine(Jump_cor());
    }
    
    public float TimeToJump;
    IEnumerator Jump_cor(){
        yield return new WaitForSeconds(TimeToJump);
        JumpPress = true;
    }
}
