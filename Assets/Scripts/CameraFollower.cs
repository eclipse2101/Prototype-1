using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    public GameObject Tank;
    public bool FirstPersonView; 
    Vector3 Offset = new Vector3(0, 5, -15); // this will be used to offset the camera from the player so that the player can see the character they are playing as
    Vector3 FirstPov = new Vector3 (0, 5, 0);
    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            FirstPersonView = !FirstPersonView;
        }
    }

    // Update is called once per frame
    void LateUpdate() //late update is a method that runs during ending of the fame the game is runned. In other words this script is runned as the last priority for the game for every frame the game is running. 
    {
        if (FirstPersonView == false)
        {
         transform.position = Tank.transform.position + Offset; // this will constanlty put the camera in the same position with the players character with a offset so that the player can see their character
        }
        else
        {
            transform.position = Tank.transform.position + FirstPov;
        }
    }
}
