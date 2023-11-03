using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheEater : MonoBehaviour
{
    private Animator animator;
    private Rigidbody2D rb;
    public float speed = 10f;

    private void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // 获取用户输入
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        // 设置动画触发器
        if (horizontalInput > 0)
        {
            animator.SetTrigger("right");
        }
        else if (horizontalInput < 0)
        {
            animator.SetTrigger("left");
        }
        else if (verticalInput > 0)
        {
            animator.SetTrigger("up");
        }
        else if (verticalInput < 0)
        {
            animator.SetTrigger("down");
        }

        // 移动逻辑
        Vector2 movement = new Vector2(horizontalInput, verticalInput).normalized;
        rb.velocity = movement * speed;
    }
}
