using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Classes 
{
    public int age;
    public string name;
    public bool alive;

    public Classes(int a, string b, bool c)
    {
        this.age = a;
        this.name = b;
        this.alive = c;
    }   
}
