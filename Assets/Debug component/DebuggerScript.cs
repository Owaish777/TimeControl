using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class DebuggerScript : MonoBehaviour
{

    
    public GameObject prefab;
    public Transform t;
    float time=0f;

    private void Update()
    {
        time += Time.deltaTime;
        if ( time > 0.2f)
        {
            time = 0;
            Instantiate(prefab, t.position, Quaternion.identity);
        }


    }


}
