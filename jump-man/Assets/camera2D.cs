using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Camera move towards the player
public class camera2D : MonoBehaviour
{
    
    public Transform player;
    private Vector3 offset;
    void Start()
    {
        
    }

    
    void Update()
    {
        //transform.position = new Vector3(player.position.x + offset.x, player.position.y + offset.y, offset.z);
        transform.position = new Vector3(player.position.x, player.position.y, -1);
    }
}
