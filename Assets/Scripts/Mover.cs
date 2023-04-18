using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    private Vector3 posUpDown;
    private Vector3 posRightLeft;

    void Start()
    {
        posUpDown = new Vector3(0, 0.09f, 0);
        posRightLeft = new Vector3(0.09f, 0, 0);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += posUpDown;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= posUpDown;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += posRightLeft;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= posRightLeft;
        }
    }
}
