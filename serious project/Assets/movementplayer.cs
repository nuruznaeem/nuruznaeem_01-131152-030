using UnityEngine;

public class movementplayer : MonoBehaviour {
    public Rigidbody rg;
    
    public float xaxis=0;
    public float yaxis = 0;
    public float zaxis = 500;
    void Start () 
    {
        

	}
	void FixedUpdate() 
    {
        rg.AddForce(xaxis, yaxis, zaxis * Time.deltaTime);
        if (Input.GetKey("left"))
        {
            rg.AddForce(-20*Time.deltaTime,0,0);   
        }
        if (Input.GetKey("right"))
        {
            rg.AddForce(20*Time.deltaTime, 0, 0);
        }
	}
}
