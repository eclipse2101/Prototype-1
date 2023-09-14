using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour
{
    public float speed = 20; 
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed); /*
        remeber that time.deltatime makes the game run by the seconds in the game instead of the amount of frames you have while running the game
        Vector 3 forward is just (0,0,1) but itsa just "easier" to read for later
        */
    }
}
