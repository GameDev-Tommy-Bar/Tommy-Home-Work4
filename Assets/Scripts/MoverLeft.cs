using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverLeft : MonoBehaviour
{
 [Tooltip("Movement vector in meters per second")]
 [SerializeField] Vector3 velocity;
    //i want to rand speed to my velocity
    // Start is called before the first frame update
 void Start(){velocity = velocity * Random.Range(1,5);}
 void Update() {transform.position += velocity * Time.deltaTime;}
 public void SetVelocity(Vector3 newVelocity) {this.velocity = newVelocity;}
}
