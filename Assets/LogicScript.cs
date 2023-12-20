using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject explosion;
    public GameObject blood;
    public GameObject Player;

    public Camera myCamera;

    public ObstacleScript obstacle;

    bool cameraDidMove = false;

    void Start()
    {
 
        spawnPlayer();
        
    }

    void Update()
    {

        Rigidbody cameraRb = myCamera.GetComponent<Rigidbody>();

        if (!cameraDidMove)

        {
            addScore();
            if (myCamera.transform.rotation.x >= .5)
            {
                cameraRb.velocity = Vector3.zero;
                cameraRb.angularVelocity = Vector3.zero;
                cameraDidMove = true;
            }
        } else
        {
            cameraRb.velocity = Vector3.back * 5;
        }



    }


    [ContextMenu("Increase Score")]
    public void addScore()

    {
        playerScore++;
        scoreText.text = playerScore.ToString();
    }

    [ContextMenu("Spawn Player")]
    public void spawnPlayer()
    {
        Instantiate(Player, new Vector3(0,0,0), Quaternion.identity);

    }

    [ContextMenu("Kill Player")]
    public void killPlayer()
    {
    Rigidbody cameraRb = myCamera.GetComponent<Rigidbody>();



            cameraRb.AddForce(0,70,0, ForceMode.Impulse);
            cameraRb.AddTorque(50, 0, 0, ForceMode.Impulse );
       
        
        //myCamera.transform.position = Vector3.Lerp(myCamera.transform.position, new Vector3(transform.position.x, transform.position.y + 4, transform.position.z), (float)0.01);
        
        //myCamera.transform.rotation = new Quaternion(myCamera.transform.rotation.x + (float)0.3, myCamera.transform.rotation.y, myCamera.transform.rotation.z, myCamera.transform.rotation.w);
        Destroy(GameObject.FindGameObjectWithTag("Player"));


        
        Instantiate(explosion, Vector3.forward, Quaternion.identity);
        Instantiate(blood, Vector3.forward, Quaternion.identity);




    }


}

