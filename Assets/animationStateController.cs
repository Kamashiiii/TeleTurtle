using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationStateController : MonoBehaviour
{
    Animator animator;
    public bool selected;
    public GameObject otherTurtle;

    public float hideCooldown;
    float hide;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("isHiding", true);
    }

    // Update is called once per frame
    void Update()
    {
        if (!otherTurtle.GetComponent<Hold>().isHeld && Input.GetKey(KeyCode.Z))
            animator.SetBool("isWalking", true);

        else
            animator.SetBool("isWalking", false);
        if (Input.GetKey(KeyCode.G))
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
        if (!selected)
            animator.SetBool("isHiding", true);
        else
            animator.SetBool("isHiding", false);
    }
}
