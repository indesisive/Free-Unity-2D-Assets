using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthbarController : MonoBehaviour
{
    public Health healthScript;
    public Image bar;

    void Update()
    {
        int health = healthScript.currHealth;
        int max = healthScript.maxhealth;
        bar.fillAmount = (float) health / max;
    }
}
