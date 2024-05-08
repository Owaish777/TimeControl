using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public float timeScale=1;
    Rigidbody2D rb;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.mass = 1 / timeScale;
        rb.gravityScale = timeScale * timeScale;
    }
    

    

}
