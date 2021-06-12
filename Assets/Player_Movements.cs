using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Player_Movements : MonoBehaviour
{
    public Rigidbody Player_movement;
    public float conti_force = 5f;
    public float right_left = 10f;

    // Update is called once per frame
    void Update()
    {
        Player_movement.AddForce(0, 0, conti_force * Time.deltaTime);
        
        if(Input.GetKey("d"))
        {
            Player_movement.AddForce(right_left, 0, 0);
        }
        else if(Input.GetKey("a"))
        {
            Player_movement.AddForce(-right_left, 0, 0);
        }
        else if(Input.GetKey("e"))
        {
            Player_movement.AddForce(0, right_left, 0);
        }
        else if(Input.GetKey("q"))
        {
            Player_movement.AddForce(0, -right_left, 0);
        }
    }
}
