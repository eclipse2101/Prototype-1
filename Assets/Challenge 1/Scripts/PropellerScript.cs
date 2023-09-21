using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerScript : MonoBehaviour
{
    public GameObject planeBlades;
    private Vector3 rotationmotion; 
    
    
    // Start is called before the first frame update
    void Start()
    {
        rotationmotion = new Vector3 (0, 0, 90);  
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate( planeBlades.transform.rotation * rotationmotion); 
    }
}
