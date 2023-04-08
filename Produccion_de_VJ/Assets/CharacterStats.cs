using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    public int HP;
    public int HP_Max;
    public int Nivel;
    public int Exp;
    public int Exp_Max;

    public int Vitalidad;
    public int Fuerza;
    public int Agilidad;
    public int Magia;
    public int Defensa;

    public int Puntos;

    private void Update()
    {
        SubirExp();
    }

    void SubirExp()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Exp += 10;
        }

        if(Exp >= Exp_Max)
        {
            Nivel++;
            Exp_Max = Mathf.RoundToInt(Exp_Max * 1.3f);
            Puntos += 5;
        }
    }

    public void SubirVitalidad()
    {
        if(Puntos > 0)
        {
            Vitalidad++;
            Puntos--;
        }
    }
}
