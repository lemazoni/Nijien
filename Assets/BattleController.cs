using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleController : MonoBehaviour
{
    [System.Serializable]
    public class Stuff
    {
        public int bullets;
        public int grenades;
        public int rockets;
        public float fuel;

        // Constructor
        public Stuff()
        {
            bullets = 1;
            grenades = 1;
            rockets = 1;
        }
    }


    // Creating an Instance (an Object) of the Stuff class
    [SerializeField]
    public Stuff myStuff = new Stuff();

    void Start()
    {
        Debug.Log(myStuff.bullets);
    }
}
