using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody2D rg;
    public SpriteRenderer rend;
    public const float SPEED_WALK = 5;
    public const float SPEED_RUN = 10;
    public float currentSpeed;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentSpeed = Input.GetKey(KeyCode.LeftShift) ? SPEED_RUN : SPEED_WALK;
        float h = Input.GetAxis("Horizontal") * currentSpeed;
        float characterVelocity = Mathf.Abs(rg.velocity.x);
        
        rg.velocity = new Vector2(h, rg.velocity.y);
        Animator.SetFloat("Speed", characterVelocity);

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
