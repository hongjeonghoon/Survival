using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public Rigidbody2D target;

    bool islive=true;

    Rigidbody2D rigid;
    SpriteRenderer spriter;


    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        spriter = GetComponent<SpriteRenderer>();
    }


     void FixedUpdate()
    {
        if (!islive)
            return;

        Vector2 dirVec = target.position - rigid.position;
        Vector2 nextVec = dirVec.normalized * speed * Time.fixedDeltaTime;
        rigid.MovePosition(rigid.position + nextVec);
        rigid.velocity = Vector2.zero;//밀려나지 않게 하는것
    }

    private void LateUpdate()
    {
        if (!islive)
            return;
        spriter.flipX = target.position.x<rigid.position.x;
    }
}
