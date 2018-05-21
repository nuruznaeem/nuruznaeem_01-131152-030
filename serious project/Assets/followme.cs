using UnityEngine;
public class followme : MonoBehaviour 
{
    public Transform myplayer;
    public Vector3 uncentered;
    void Update () 
    {
        transform.position = myplayer.position + uncentered;
	}
}
