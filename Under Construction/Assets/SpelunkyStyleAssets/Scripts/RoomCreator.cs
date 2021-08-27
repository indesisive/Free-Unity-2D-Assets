using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomCreator : MonoBehaviour
{    
    public GameObject[] rooms;
    bool flag = false;    
    void Update()
    {
        int r = Random.Range(0, rooms.Length);
        if (MapGenerator.firstStageDone == true && !flag)
        {
            flag = true;
            Debug.Log("Succesful");
            //Generate Room\\            
            Instantiate(rooms[r], transform);
        }        
    }
}
