using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawnScript : MonoBehaviour
{

    public GameObject obstacle;
    public float spawnRate = 2;
    public float timer = 0;
    public bool shouldSpawn = true;
    // Start is called before the first frame update
    void Start()
    {
        if (shouldSpawn)
        {
            spawnObstacle();
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (shouldSpawn)
        {
            if (timer < spawnRate)
            {
                timer += Time.deltaTime;
            }
            else
            {

                spawnObstacle();
                timer = 0;
            }
        }

    }

    void spawnObstacle()
    {
        Instantiate(obstacle, new Vector3(transform.position.x - 1,transform.position.y,transform.position.z), transform.rotation);
    }


}
