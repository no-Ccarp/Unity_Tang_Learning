using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson35 : MonoBehaviour
{
    //public Sprite[] sp;

    //private SpriteRenderer sr;

    //private float time = 0;

    //private int nowIndex = 0;
    private Animator animator;
     
    void Start()
    {
        animator = GetComponent<Animator>();

        //sr = GetComponent<SpriteRenderer>();
        //sr.sprite = sp[nowIndex];
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            animator.SetBool("isDead", true);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            animator.SetBool("isDead", false);
        }


        ////每次增加帧间隔时间
        //time += Time.deltaTime;
        ////当帧间隔时间大于某个值   进行图片切换
        //if (time >= 0.1f)
        //{
        //    nowIndex++;
        //    if (nowIndex >= sp.Length)
        //        nowIndex = 0;
        //    sr.sprite = sp[nowIndex];
        //    time = 0;
        //}
    }
}
