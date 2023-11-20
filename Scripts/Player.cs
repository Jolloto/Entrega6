using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour

    //A2
{
    [SerializeField] private float speed = 10.0f;
    [SerializeField] private GameObject dogPrefab;


    private float verticalInput;


    
    void Update()
    {
      //A2

        //Disparo

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShootDog();
        }

    }

    private void ShootDog()
    {
        //A2

        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

    }
}
