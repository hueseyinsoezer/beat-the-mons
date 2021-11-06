using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class rigidbodyWall : MonoBehaviour
{

    Rigidbody2D myBody;

   

    void Start()
    {

        myBody =GetComponent<Rigidbody2D>();


        myBody.gravityScale = 0;

    }

    
}
