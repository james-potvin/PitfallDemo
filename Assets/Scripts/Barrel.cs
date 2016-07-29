using UnityEngine;
using System.Collections;

public class Barrel : MonoBehaviour
{

    public float speed;
    public int damage;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	    Vector3 pos = transform.position;

	    transform.position = new Vector3(pos.x - speed, pos.y, pos.z);

	    if( transform.position.x < -10 )
	    {
	        Destroy( this.gameObject );
	    }
	}

    void OnTriggerStay2D( Collider2D collider )
    {
        if ( collider.gameObject.tag == "Player" )
        {
            Debug.Log( "Dealt damage" );
            collider.gameObject.GetComponent<PlayerScript>().takeDamage( damage );
        }
    }
}
