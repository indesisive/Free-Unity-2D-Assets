using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enterance : MonoBehaviour
{
    public GameObject player;
    public bool playerSpawned = false;
    public Transform spawnPos;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void Update()
    {
        if (MapGenerator.readyForPlayer && !playerSpawned)
        {
            player.transform.position = spawnPos.position;
            playerSpawned = true;
        }
    }
}
