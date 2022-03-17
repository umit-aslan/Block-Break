using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour
{
    public int Health; // Health of the block
    void Start()
    {
        
    }

    void Update()
    {
        
    }

   private void OnCollisionEnter2D(Collision2D other) 
   {
     if (true)
     {
         Health--;
         if (Health <= 0)
         {
             Destroy(gameObject);
         }
     }
   }
}
