using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Manager : MonoBehaviour
{
 public Transform ball;
 public Transform cam;

    void Update()
    {
        checkBallPos();
    }


    private void checkBallPos(){

        if(ball.position.y <=cam.position.y-7){
           SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    public void afterScene(){
        if (BlockController.blockNumber <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
       
    }
} 
