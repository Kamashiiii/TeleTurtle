using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationStateController : MonoBehaviour
{
    Animator animator;

    public float hideCooldown;
    float hide;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("z"))
        {
            animator.SetBool("isWalking", true);
        }
        else
            animator.SetBool("isWalking", false);
        if (Input.GetKey("g"))
        {

            if (!animator.GetBool("isHiding"))
            {
                if (Time.time - hide < hideCooldown)
                    return;
                animator.SetBool("isHiding", true);
                hide = Time.time;
            }
            else
            {
                if (Time.time - hide < hideCooldown)
                    return;
                animator.SetBool("isHiding", false);
                hide = Time.time;
            }
        }
        if (Input.GetMouseButtonDown(0))
        {
            animator.SetBool("isAttacking", true);
        }
        else
            animator.SetBool("isAttacking", false);
    }
}
