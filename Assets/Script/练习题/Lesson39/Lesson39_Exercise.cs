using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson39_Exercise : MonoBehaviour
{
    public Transform leftArm;
    private float z;
    private Vector3 mousePos;
    // Start is called before the first frame update
    void Start()
    {
        z = Camera.main.WorldToScreenPoint(leftArm.position).z;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            mousePos = Input.mousePosition;
            mousePos.z = z;
            leftArm.position = Camera.main.ScreenToWorldPoint(mousePos);
        }
    }
}
