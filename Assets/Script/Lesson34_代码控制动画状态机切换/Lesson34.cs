using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson34 : MonoBehaviour
{
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        //animator.SetFloat("条件名", 1.2f);
        //animator.SetInteger("条件名", 1);
        //animator.SetBool("条件名", true);
        //animator.SetTrigger("条件名");

        //animator.GetFloat("条件名");
        //animator.GetInteger("条件名");
        //animator.GetBool("条件名");

        //直接播放动画的方法
        //animator.Play("状态名");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {

            animator.SetBool("Change", true);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetBool("Change", false);
        }
    }
}
