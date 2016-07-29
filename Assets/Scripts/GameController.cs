using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    private GameObject player;

    // Use this for initialization
    void Start ()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
	
	// Update is called once per frame
	void Update ()
    {
	    if( player.transform.position.y < -5 )
	    {
	        player.GetComponent<PlayerScript>().loseLife();
	    }
	}
}
