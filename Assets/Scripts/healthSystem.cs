using UnityEngine;
using System;
public class HealthSystem
{
    private float health;
    private float healthMax;
    public event EventHandler OnHealthChanged;
    public HealthSystem(float max)
    {
        healthMax = max;
        health = max;
    }
    public float GetHealth()
    {
        return health;
    }
    public float GetHealthPercentage()
    {
       return health/ healthMax;
    }

    public void Damage(float attack)
    {
        health -= attack;
        if (health < 0)
            health = 0;
        if (OnHealthChanged != null) OnHealthChanged(this, EventArgs.Empty);
    }
}