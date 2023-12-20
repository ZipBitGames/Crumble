using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMoveScript : MonoBehaviour

{

    public Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = Vector3.back * 5;

        if (rb.position.z < -150)
        {
            Destroy(gameObject);
        }
    }
}
