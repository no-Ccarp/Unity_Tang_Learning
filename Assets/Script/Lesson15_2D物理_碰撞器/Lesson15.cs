using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson15 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rigid = this.GetComponent<Rigidbody2D>();
        //刚体加力
        rigid.AddForce(new Vector2(0, 100));
        //速度
        rigid.velocity = new Vector2(1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
