using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarksaBasicB : MonoBehaviour
{
    float charSpeed = 2;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * charSpeed); //Moves Character Forward and Back
        transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * charSpeed);
        transform.Rotate(Vector3.up * Input.GetAxis("Mouse X"));
    }
}
