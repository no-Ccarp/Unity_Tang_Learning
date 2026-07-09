using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson10 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject obj = new GameObject();
        SpriteRenderer st = obj.AddComponent<SpriteRenderer>();

        st.sprite = Resources.Load<Sprite>("dead3");

        Sprite[] sr = Resources.LoadAll<Sprite>("RobotBoyCrouchSprite");
        st.sprite = sr[5];

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
