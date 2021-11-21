using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour

{
    public static playerController Instance;
    public GameObject flappy;
    public GameObject[] playerPrefabs;
    public Transform playerPos;
 

    void Awake()
    {
        Instance = this;
    }


    void Start()
    {

        flappy = Instantiate(playerPrefabs[Random.Range(0, playerPrefabs.Length)], playerPos.position, transform.rotation);
        flappy.transform.parent = playerPos;
       
    }

   
  
}
