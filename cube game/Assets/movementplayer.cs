using UnityEngine;

public class movementplayer : MonoBehaviour 
{
    //rigidbody component
    public Rigidbody myplayer;
    public float sides = 500f;
    public float goforward = 2000f;
	void Start()
    {
        
    }
    // we need to do some physics so fixedupdate is the best way.
	void FixedUpdate () 
    {
        myplayer.AddForce(0, 0, goforward*Time.deltaTime);
        if (Input.GetKey("left"))
        {
            myplayer.AddForce(-sides*Time.deltaTime,0,0);
        }
        if (Input.GetKey("right"))
        {
            myplayer.AddForce(sides*Time.deltaTime, 0, 0);
        }
	}
}
