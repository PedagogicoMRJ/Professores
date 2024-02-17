using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public bool isPlayerLeftGoal;
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.CompareTag("Ball")){
            if(!isPlayerLeftGoal){
                Debug.Log("Player Left Scored");
                GameObject.Find("GameManager").GetComponent<GameManager>().PlayerLeftScored();
            }
            else{
                Debug.Log("Player Right Scored");
                GameObject.Find("GameManager").GetComponent<GameManager>().PlayerRightScored();
            }
        }
    }

}
