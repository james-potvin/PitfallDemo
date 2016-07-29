using UnityEngine;
using System.Collections;

public class Alligator : MonoBehaviour
{

    public float stateChangeTime;
    private float timer;
    private bool open;

    public Sprite closedMouth;
    public Sprite openMouth;

	// Use this for initialization
	void Start ()
	{
	    timer = stateChangeTime;
	    open = false;
	}
	
	// Update is called once per frame
	void Update ()
	{
	    timer -= Time.deltaTime;

	    if( timer <= 0 )
	    {
	        timer = stateChangeTime;
	        open = !open;

	        if( open )
	        {
	            GetComponent<SpriteRenderer>().sprite = openMouth;
	        }
	        else
	        {
                GetComponent<SpriteRenderer>().sprite = closedMouth;
            }
	    }
	}

    void OnCollisionStay2D( Collision2D collider )
    {
        if( collider.gameObject.tag == "Player" && open)
        {
            collider.gameObject.GetComponent<PlayerScript>().loseLife();
        }
    }
}
