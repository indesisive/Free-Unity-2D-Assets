using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missed : MonoBehaviour
{
    public GameObject player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        player.GetComponent<Health>().currHealth -= 1;
        player.GetComponent<Animator>().SetTrigger("Missed");
    }
}
