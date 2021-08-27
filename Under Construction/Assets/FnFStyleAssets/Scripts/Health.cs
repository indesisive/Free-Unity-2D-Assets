using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int currHealth;
    public int maxhealth;
    
    void Start()
    {
        currHealth = maxhealth;
    }
        
    void Update()
    {
        if (currHealth > maxhealth)
        {
            currHealth = maxhealth;
        }

        if (currHealth <= 0)
        {
            SceneManager.LoadScene("Main Menu Demo");
        }
    }
}
