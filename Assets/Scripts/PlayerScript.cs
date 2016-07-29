using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour
{
    public float speed = .05f;
    public int jumpForce = 200;

    //used to check whether the player can jump
    private bool onGround;

    private int lives;
    private int health;
    public int maxHealth;

    private Vector3 startingPosition;

	// Use this for initialization
	void Start ()
	{
	    onGround = true;

	    lives = 3;
	    health = maxHealth;

	    startingPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if( Input.GetKey( KeyCode.LeftArrow ) )
	    {
	        transform.position += Vector3.left * speed;
	    }
	    if( Input.GetKey( KeyCode.RightArrow ) )
	    {
	        transform.position += Vector3.right * speed;
	    }

	    if( Input.GetKeyDown( KeyCode.Space ) && onGround)
	    {
	        GetComponent<Rigidbody2D>().AddForce( Vector2.up * jumpForce);
	        onGround = false;
	    }
	}

    //reduce players health when it reaches 0 lose a life
    public void takeDamage( int damageAmount )
    {
        health -= damageAmount;
        if( health <= 0 )
        {
            loseLife();
        }
    }

    public int getHealth()
    {
        return health;
    }

    //lose a life and go back to beggining
    public void loseLife()
    {
        lives--;
        health = maxHealth;
        //send the player back to start
        transform.position = startingPosition;
    }

    public int getLives()
    {
        return lives;
    }

    void OnCollisionEnter2D( Collision2D collider )
    {
        //check if we are colliding with the ground beneth us
        if( collider.gameObject.tag == "Ground" && collider.transform.position.y < transform.position.y )
        {
            onGround = true;
        }
    }
}
