using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessNoteMaker : MonoBehaviour
{
    public GameObject[] noteSpawns;
    public float delay;

    public GameObject upNote;
    public GameObject downNote;
    public GameObject leftNote;
    public GameObject rightNote;

    bool everyOther = false;

    public int inbetween = 30;
    public int indicator = 0;

    GameObject inNote;    

    private void Update()
    {
        if (PauseMenu.isGamePaused == false)
        {
            if (indicator != inbetween)
            {
                indicator++;
            }
            else
            {
                Updatex30();
                indicator = 0;
                inbetween = Random.Range(30, 85);
            }
        }
    }
    public void Updatex30()
    {
        int r = Random.Range(0, noteSpawns.Length);
        delay = Random.Range(1.5f, 4.5f);

        StartCoroutine(SpawnNote(noteSpawns[r]));        
    }
    IEnumerator SpawnNote(GameObject node)
    {
        if (node.CompareTag("RedNode"))
        {
            Instantiate(leftNote, node.transform.position, Quaternion.identity);
            Debug.Log("Spawned on " + node.tag);
        }
        else if (node.CompareTag("BlueNode"))
        {
            Instantiate(upNote, node.transform.position, Quaternion.identity);
            Debug.Log("Spawned on " + node.tag);
        }
        else if (node.CompareTag("GreenNode"))
        {
            Instantiate(rightNote, node.transform.position, Quaternion.identity);
            Debug.Log("Spawned on " + node.tag);
        }
        else if (node.CompareTag("PurpleNode"))
        {
            Instantiate(downNote, node.transform.position, Quaternion.identity);
            Debug.Log("Spawned on " + node.tag);
        }

        yield return new WaitForSeconds(3);
    }
}