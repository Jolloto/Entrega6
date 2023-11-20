using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perros : MonoBehaviour
{
    //A2

    [SerializeField] private float speed = 10.0f;
    

    private float verticalInput;

    
    void Update()
    {
      //A2

        //verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * speed * Time.deltaTime);


    }
}
