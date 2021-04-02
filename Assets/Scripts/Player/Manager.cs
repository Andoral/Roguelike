using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public static int maxHealth;
    public static int currentHealth;
    public static bool isDead;
    public int hp;

    void Start()
    {
    	isDead = false;
        maxHealth = 100;
        currentHealth = maxHealth;
    }

    
    void Update()
    {
        hp=currentHealth;
    }
}
