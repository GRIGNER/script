using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody2D rg;
    public SpriteRenderer rend;
    public float Speed = 5;
    public float Run = 10;
    public Animator Animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal") * Speed;
        //float r = Input.GetKey(KeyCode.LeftShift) * Run;
        float characterVelocity = Mathf.Abs(rg.velocity.x);
        
        rg.velocity = new Vector2(h, rg.velocity.y);
        //rg.velocity = new Vector2(r, rg.velocity.y);
        Animator.SetFloat("Speed", rg.velocity.x);

        if(h > 0)
        {
            rend.flipX = false;
        }

        if(h < 0)
        {
            rend.flipX = true;
        }
    }

}
