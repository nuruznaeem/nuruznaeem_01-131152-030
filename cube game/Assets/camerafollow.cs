using UnityEngine;
public class camerafollow : MonoBehaviour 
{
    public Transform player;
    public Vector3 outofcube;
    void Update () 
    {
        transform.position = player.position + outofcube;
	}
}
