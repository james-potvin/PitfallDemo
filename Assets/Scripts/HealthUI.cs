using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{

    private GameObject player;

	// Use this for initialization
	void Start ()
    {
	    player = GameObject.FindWithTag( "Player" );
	}
	
	// Update is called once per frame
	void Update ()
	{
	    GetComponent<Text>().text = "Health: " + player.GetComponent<PlayerScript>().getHealth().ToString();
	}
}
