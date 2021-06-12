using UnityEngine;

public class Stopping : MonoBehaviour
{
    public Player_Movements move;

    void OnCollisionEnter (Collision colide)
    {
        if(colide.collider.tag == "Stopping")
        {
            move.enabled = false;
        }
    }
}
