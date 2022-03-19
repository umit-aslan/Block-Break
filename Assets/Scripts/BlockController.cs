using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour
{
    public int Health; // Health of the block
   public static int blockNumber; // Number of blocks
   public bool breakingBlocks; // Is the block breaking?
   private Game_Manager gm;

    void Start()
    {
        gm=GameObject.Find("Game_Manager").GetComponent<Game_Manager>(); 
      breakingBlocks=(this.tag=="Block");
      if(breakingBlocks)
      {
        blockNumber++;
      }

    }

   private void OnCollisionEnter2D(Collision2D other) 
   {
     if (true)
     {
         Health--;

         if (Health <= 0)   
         {
             blockNumber--;
             Destroy(gameObject);
             gm.afterScene();
         }
     }
   }
}
