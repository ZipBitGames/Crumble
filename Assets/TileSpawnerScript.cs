using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSpawnerScript : MonoBehaviour
{


    public float spawnRate = 1;
    public float timer = 0;
    public int tile = 0;
    public List<GameObject> choiceList;
    public List<GameObject> intersectionList;
    public List<GameObject> blankList;

    // Start is called before the first frame update
    void Start()
    {
        choiceList = new List<GameObject>(Resources.LoadAll<GameObject>("Choices"));
        intersectionList = new List<GameObject>(Resources.LoadAll<GameObject>("Intersections"));
        blankList = new List<GameObject>(Resources.LoadAll<GameObject>("Blanks"));

        spawnTile();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnTile();
            timer = 0;
        }

    }

    void spawnTile()
    {
        if (tile == 0)
        {
            Instantiate(intersectionList[0], transform.position, transform.rotation);
            tile++;
        }

        else if (tile == 1)
        {
            Instantiate(choiceList[0], transform.position, transform.rotation);
            tile++;
        }
        else
        {
            
            Instantiate(blankList[0], transform.position, transform.rotation);
            tile = 0;

        }
        
    }
}
