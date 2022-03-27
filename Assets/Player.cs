using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float move;
    public float jump;

    private Rigidbody2D rigidplayer;

    public bool grounded;
    public LayerMask whatIsGround;

    private Collider2D colliderplayer;

    // Start is called before the first frame update
    void Start()
    {
        rigidplayer = GetComponent<Rigidbody2D>();
        colliderplayer = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {

        grounded = Physics2D.IsTouchingLayers(colliderplayer, whatIsGround);
        rigidplayer.velocity = new Vector2(move, rigidplayer.velocity.y);
    
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            if (grounded)
            {
                rigidplayer.velocity = new Vector2(jump, rigidplayer.velocity.x);
            }
        }
    }
}
