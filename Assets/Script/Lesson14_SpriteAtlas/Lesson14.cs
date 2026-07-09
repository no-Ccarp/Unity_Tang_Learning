using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class Lesson14Ex : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject obj = new GameObject();
        SpriteRenderer sr = obj.AddComponent<SpriteRenderer>();
        //加载图集资源
        SpriteAtlas spriteAtlas = Resources.Load<SpriteAtlas>("MyAtlas");
        //加载图集资源中的某一张图片
        sr.sprite = spriteAtlas.GetSprite("1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
