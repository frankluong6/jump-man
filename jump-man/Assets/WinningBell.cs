using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinningBell : MonoBehaviour
{
    public Collider2D bell;
    public Collider2D jump_man;
    void Start()
    {
        //bell = GameObject.FindGameObjectWithTag("bell").GetComponent<Collider2D>();
        //jump_man = GameObject.FindGameObjectWithTag("jump_man").GetComponent<Collider2D>();
    }

   
    void Update()
    {
        if(bell.IsTouching(jump_man))
        {
            print("Jump man is touching the bell.");
            Application.Quit();
            print("Ending game!");
        }
    }
}
