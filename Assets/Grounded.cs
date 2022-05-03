using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : MonoBehaviour
{

    character Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = gameObject.transform.parent.gameObject.GetComponent<character>();
    }

    void OnCollisionEnter2D(Collision2D collisor)
    {
        if(collisor.gameObject.layer == 6)
        {
            Player.isJumping = false;
        }
        
    }

    void OnCollisionExit2D(Collision2D collisor)
    {
        if(collisor.gameObject.layer == 6)
        {
            Player.isJumping = true;
        }
    }
}
