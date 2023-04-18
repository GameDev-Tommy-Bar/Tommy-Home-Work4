using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinshGame : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D other) {
    
        if(other.tag == "Player"){
            Debug.Log("You Win");
            Application.Quit();
            
    ;
        }
        }
}
