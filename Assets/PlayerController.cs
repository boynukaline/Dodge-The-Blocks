using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rb;
    private float _moveX;
    private float playerBounds = 4.0f;
    public float moveSpeed = 10f;


    // Update is called once per frame
    void Update()
    {
        _moveX = Input.GetAxisRaw("Horizontal") * moveSpeed;

        if (rb.position.x >= playerBounds)
            rb.position = new Vector2(playerBounds, rb.position.y);
        else if (rb.position.x <= -playerBounds)
            rb.position = new Vector2(-playerBounds, rb.position.y);

    }

    void FixedUpdate()
    {
        MovePlayer();
    }

    void MovePlayer()
    {

        rb.velocity = new Vector2(_moveX, rb.velocity.y);

    }
}
