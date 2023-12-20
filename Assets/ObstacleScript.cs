using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    public Rigidbody myRigidBody;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        myRigidBody.velocity = Vector3.back * 5;



        if (myRigidBody.position.z < -15)
        {
            Destroy(gameObject);
        }
    }
}






