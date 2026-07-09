using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerObjectLesson24 : MonoBehaviour
{
    private Rigidbody2D rigidBody2D;
    private float h;
    public float moveSpeed = 5;

    private SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //左右移动
        h = Input.GetAxis("Horizontal");
        rigidBody2D.velocity = new Vector2(h * moveSpeed, rigidBody2D.velocity.y);
        
        //跳跃
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rigidBody2D.AddForce(Vector2.up * 300);
        }

        //转向
        if (h > 0)
            sr.flipX = false;
        if (h < 0)
            sr.flipX = true;
    }
}
