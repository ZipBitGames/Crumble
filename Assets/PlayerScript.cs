using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    public Rigidbody myRigidBody;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            myRigidBody.position = myRigidBody.position + (Vector3.left * (float).003);
        }

        if (Input.GetMouseButton(1))
        {
            myRigidBody.position = myRigidBody.position + (Vector3.right * (float).003);
        }

    }


    [ContextMenu("Kill Player")]
    public void killPlayer()
    {
        Destroy(gameObject);
    }
}
