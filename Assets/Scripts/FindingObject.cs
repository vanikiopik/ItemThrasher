using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine.EventSystems;
using UnityEngine;

public class FindingObject : ExplosionForce
{


    private void OnCollisionEnter2D(Collision2D collision)
    {

    }

    //If clicked on Object
    private void OnMouseDown()
    {
        Debug.Log("asd");
        ApplyExplosionForce();
        GameObject.Destroy(gameObject);
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            
        }
    }

    
}
