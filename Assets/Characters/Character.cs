using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private int health = 10;
    public int Health
    {
        get
        {
            return health;
        }

        set
        {
            if (value <= 0)
                health = 0;
            else
                health = value;
            Debug.Log(gameObject.transform.name + "  Health = " + Health + "   health = " + health);
        }
    }
}
