using UnityEngine;
public class collision : MonoBehaviour
{
    public movementplayer move;
    void OnCollisionEnter(Collision itsinfo)
    {
        if (itsinfo.collider.tag == "outcube")
        {
            move.enabled = false;
        }

    }
}
