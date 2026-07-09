using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson30 : MonoBehaviour
{
    private Animation animation;


    // Start is called before the first frame update
    void Start()
    {
        animation = GetComponent<Animation>();
        animation.Play("1");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
