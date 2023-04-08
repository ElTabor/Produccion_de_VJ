using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    float life;
    float maxLife;

    public void GetDamage(float damageTaken)
    {
        life -= damageTaken;
        if (life <= 0) Destroy(gameObject);
    }

    public void RestoreHealth(float healthRestored)
    {
        life += healthRestored;

        if (life >= maxLife) life = maxLife;
    }
}