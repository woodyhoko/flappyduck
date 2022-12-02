using UnityEngine;
using System;
public class pipeHealth
{
    public float health;
    private float healthMax;
    public pipeHealth()
    {
    }
    public void init(float max)
    {
        healthMax = max;
        health = max;
    }
    public bool CheckDie()
    {
        if (health < 0){
            return true;
        }
        return false;
    }
    public void TakeDamage(float damage)
    {
        health -= damage;
    }
}