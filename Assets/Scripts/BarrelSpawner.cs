using UnityEngine;
using System.Collections;

public class BarrelSpawner : MonoBehaviour
{
    public GameObject theBarrel;

    public float timeBetweenBarrels;
    private float timer;

	// Use this for initialization
	void Start ()
	{
	    timer = timeBetweenBarrels;
	}
	
	// Update is called once per frame
	void Update ()
	{
	    timer -= Time.deltaTime;

	    if( timer <= 0 )
	    {
	        //spawn barrel
            Debug.Log( "spawn barrel" );
	        Instantiate( theBarrel, transform.position, Quaternion.identity );
	        timer = timeBetweenBarrels;
	    }
	}
}
