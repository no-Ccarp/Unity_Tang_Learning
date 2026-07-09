using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletObj : MonoBehaviour
{
    public float moveSpeed = 1;
    private Vector3 nowDir;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 3f);
    }

    public void ChangeMoveDir(Vector3 dir)
    {
        nowDir = dir;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveSpeed * Time.deltaTime * nowDir);
    }
}
