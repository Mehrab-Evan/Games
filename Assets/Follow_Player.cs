using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class Follow_Player : MonoBehaviour
{
    public Transform playerposition;
    public Vector3 behind_player;

    // Update is called once per frame
    void Update()
    {
        transform.position = playerposition.position + behind_player;
    }
}
