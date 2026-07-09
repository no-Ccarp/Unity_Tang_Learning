using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson10_Ex : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject obj = new GameObject();
        SpriteRenderer sr = obj.AddComponent<SpriteRenderer>();
        sr.sprite = MultipleMgr.Instance.GetSprite("RobotBoyIdleSprite", "RobotBoyIdle16");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
