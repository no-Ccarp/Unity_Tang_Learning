using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerObjcetIsometric : MonoBehaviour
{
    public float moveSpeed = 3;

    private float h;
    private float v;

    private SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //获取输入
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        //进行移动
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime * h);
        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime * v);

        //转向
        if (h > 0)
            sr.flipX = false;
        if (h < 0)
            sr.flipX = true;
    }
}
