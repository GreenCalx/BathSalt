using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attributes
{
    public Attributes()
    {
        HP          = 0f;
        ENERGY      = 0f;
        EXPERIENCE  = 0f;

        computeStats();
    }

    // -----------------------------
    // MAIN ATTRIBUTES
    // -----------------------------
    public float HP;
    public float ENERGY;
    public float EXPERIENCE;


    // -----------------------------
    // COMPUTED ATTRIBUTES
    // -----------------------------
    public int LEVEL;

    public void computeStats()
    {
        LEVEL = EXPERIENCE / 100 ;
    }

}
