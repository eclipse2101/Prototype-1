using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour
{
    public float speed = 20;
    public float turnSpeed;
    public float horizontalInput;
    public float forwardInput;   
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal"); // this will get the horizontal inputs from unity. You can customize what the inputs are by doing edit > Project Settings. This will allow you to customize the inputs of your axis but its best not to do that unless nessarcy. 
        forwardInput = Input.GetAxis("Vertical");
        
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput); /*
        remeber that time.deltatime makes the game run by the seconds in the game instead of the amount of frames you have while running the game
        Vector 3 forward is just (0,0,1) but itsa just "easier" to read for later
        */
        
        // this will affect how fast your character will be able to turn 
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
