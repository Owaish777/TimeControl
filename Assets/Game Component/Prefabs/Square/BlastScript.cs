using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.Jobs;

public class BlastScript : MonoBehaviour
{
    public float range = 1;
    public LayerMask layer;
    public float blastSpeed = 50;

    Rigidbody2D rb;
    Vector2 dir;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(rb.velocity.sqrMagnitude > 10)
        {
            Collider2D[] c;
            c = Physics2D.OverlapCircleAll(new Vector2(transform.position.x, transform.position.y), 50, layer);
            for (var i = 0; i <= c.Length - 1; i++)
            {
                dir.x = c[i].transform.position.x - transform.position.x;
                dir.y = c[i].transform.position.y - transform.position.y;

                c[i].attachedRigidbody.velocity += blastSpeed * dir.normalized / dir.magnitude;
                Debug.Log(c[i].gameObject.name);
            }
            Destroy(gameObject);
            
        }



        
    }

}
