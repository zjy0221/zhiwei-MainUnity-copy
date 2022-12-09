using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 主角移動街道使用 : MonoBehaviour
{
    public float speed = 3f;
    public Rigidbody2D rb;
    public Collider2D cd;

    void Start()
    {
        cd = GetComponent<Collider2D>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        playMove();
    }

    void playMove()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float faceNum = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(speed * horizontal,rb.velocity.y);
        if(faceNum!=0)
        {
            transform.localScale = new Vector3(-faceNum,transform.localScale.y,transform.localScale.z);
        }
    } 

}
