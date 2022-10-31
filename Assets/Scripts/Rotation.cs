using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            transform.Rotate(5, 0, 0);
        } 
        else if (Input.GetKeyDown(KeyCode.Y))
        {
            transform.Rotate(0, 5, 0);
        } 
        else if (Input.GetKeyDown(KeyCode.Z))
        {
            transform.Rotate(0, 0, 5);   
        } 
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.rotation = Quaternion.identity;
        }
    }
}
