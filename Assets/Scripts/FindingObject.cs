using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine.EventSystems;
using UnityEngine;

public class FindingObject : MonoBehaviour
{


    private void OnCollisionEnter2D(Collision2D collision)
    {

    }

    private void OnMouseDown()
    {
        Debug.Log("asd");
        
        GameObject.Destroy(gameObject);
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            
        }
    }

    
}
