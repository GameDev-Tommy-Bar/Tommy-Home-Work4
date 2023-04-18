using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Destroycode : MonoBehaviour {
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;
  
  
    
    private void OnTriggerEnter2D(Collider2D other) {
        //   Debug.Log("other = "+ other.tag + "this = " + this.tag);
      if (other.tag == triggeringTag && enabled) {  
          Destroy(this.gameObject);
           // Destroy(other.gameObject);
             }   
    }
    

    private void Update() {
        /* Just to show the enabled checkbox in Editor */
    }
}

