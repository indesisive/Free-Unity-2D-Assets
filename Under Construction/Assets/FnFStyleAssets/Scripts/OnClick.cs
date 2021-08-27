using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClick : MonoBehaviour
{
    public bool clickedSpace;
    public bool touching;
    public KeyCode arrow;

    public GameObject player;
    public Animator playerAnim;
    
    Animator anim;

    public int colorInt;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(arrow) && touching)
        {
            anim.SetTrigger("Pressed");
            StartCoroutine(ClickedSpaceAtTheMoment());            
        }
        if (Input.GetKeyDown(arrow) && !touching)
        {
            anim.SetTrigger("Pressed");
            playerAnim.SetTrigger("Missed");
            player.GetComponent<Health>().currHealth -= 1;            
        }

    }
    IEnumerator ClickedSpaceAtTheMoment()
    {
        clickedSpace = true;
        yield return new WaitForSecondsRealtime(0.05f);
        clickedSpace = false;
    }
    void OnTriggerStay2D(Collider2D collision)
    {
        touching = true;
        if (clickedSpace)
        {
            Destroy(collision.gameObject);            
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        touching = false;
    }
}
