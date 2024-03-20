using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    public float topBound = 40; 
    public float bottomBound = -30; 
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < bottomBound)
        {
           Destroy(gameObject); // destorys prefabs
        }
     }
     
}
