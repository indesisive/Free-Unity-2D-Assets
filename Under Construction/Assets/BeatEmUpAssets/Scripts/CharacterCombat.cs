using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCombat : MonoBehaviour
{
    public Animator animator;
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Attack();
        }
    }
    void Attack()
    {
        //Play anim
        animator.SetTrigger("Attack");
        //detect enimies
        Collider2D[] hitEnimies = Physics2D.OverlapCircleAll(attackPoint.position,attackRange,enemyLayers);
        //damage enemy
        foreach (Collider2D enemy in hitEnimies)
        {
            Debug.Log("We hit " + enemy.name);
            enemy.GetComponent<Animator>().SetTrigger("Hit");
        }
    }
}
