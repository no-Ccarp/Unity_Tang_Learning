using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerObject : MonoBehaviour
{
    public int moveSpeed = 5;
    private float h;
    private SpriteRenderer sr;
    private Rigidbody2D rigid;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rigid = GetComponent<Rigidbody2D>();
    }

// Update is called once per frame
void Update()
    {
        
        h = Input.GetAxis("Horizontal");
        //this.transform.Translate(moveSpeed * Time.deltaTime * Vector3.right * h);

        //重力会给予物体y方向的速度，这样的写法能够保证y方向上的力不变
        if(h != 0)
            rigid.velocity = new Vector2(h * moveSpeed, rigid.velocity.y);
        if (h < 0)
            sr.flipX = true;
        else if (h > 0)
            sr.flipX = false;

        if(Input.GetKeyDown(KeyCode.J))
        {
            //创建子弹预设体
            GameObject obj = GameObject.Instantiate(Resources.Load<GameObject>("BulletObj"), transform.position + new Vector3(sr.flipX ? -0.3f : 0.3f,0.5f,0),Quaternion.identity);
            obj.GetComponent<BulletObj>().ChangeMoveDir(sr.flipX ? Vector3.left : Vector3.right);


            //以下代码是错误示范，不能这样写
            //obj = new GameObject();
            //Sprite bullet = Resources.Load<Sprite>("bullet");
            //obj.transform.position = transform.position;
            //SpriteRenderer sr2 = obj.AddComponent<SpriteRenderer>();
            //sr2.sprite = bullet;

            //if (sr.flipX == true)
            //    obj.transform.Translate(1 * Time.deltaTime * Vector3.left);
            //else
            //    obj.transform.Translate(1 * Time.deltaTime * Vector3.right);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            //向上加一个瞬时的力 
            rigid.AddForce(Vector2.up * 600);
        }
        
        //if (Input.GetKeyDown(KeyCode.A))
        //    sr.flipX = true;
        //if (Input.GetKeyDown(KeyCode.D))
        //    sr.flipX = false;
    }
}
