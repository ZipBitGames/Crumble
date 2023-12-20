using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObstacleCollisionScript : MonoBehaviour
{
    // Start is called before the first frame update

    public LogicScript logic;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            Debug.Log("COLLISION PLAYER");
            print("test");
            Destroy(gameObject);
            logic.killPlayer();
        } else
        {
            Debug.Log("COLLISION Nonplayer");
        }



    }
}
