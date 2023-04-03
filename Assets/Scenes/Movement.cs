using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float jump;
    private float Move;
    public bool isJumping;

    private Rigidbody2D character;
    void Start()
    {
        character = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Move = Input.GetAxis("Horizontal");

        character.velocity = new Vector2(Move, character.velocity.y);

        if(Input.GetButtonDown("Jump") && isJumping == false)
        {
            character.AddForce(new Vector2(character.velocity.x, jump));
        }
   
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }
    
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = true;
        }
    }

    private int _speed;

    public Movement(int speed, float jump)
    {
        this._speed = 50;
    }

    public int GetSpeed()
    {
        return this._speed;
    }

    public void SetSpeed(int speed)
    {
        this._speed = speed;
    }

    
}
