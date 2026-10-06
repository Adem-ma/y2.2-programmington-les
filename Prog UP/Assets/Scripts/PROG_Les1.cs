using NUnit.Framework;
using Unity.Mathematics.Geometry;
using System.Collections.Generic;
using UnityEngine;

public class PROG_Les1 : MonoBehaviour
{

    public class erwinPerson
    {
        public string Name;
        public int Score;
        public bool Alive;
        public int HP;

        public void PlayerShout()
        {

            Debug.Log($"I am {Name}, my hp is {HP}, my score is {Score}.");
        }

    }
   
    erwinPerson eP = new erwinPerson();
    erwinPerson eP2 = new erwinPerson();

    private void Erwin1()
    {
        eP.Name = "Erwin1";
        eP.Score = 2;
        eP.Alive = true;
        eP.HP = 100;

        eP.PlayerShout();

    }

    private void Erwin2()
    {
        eP2.Name = "Erwin2";
        eP2.Score = 30;
        eP2.Alive = true;
        eP2.HP = 150;

        eP2.PlayerShout();

    }

 


    private void erwinAttacked(int value)
    {
        eP.HP -= value;

        if (eP.HP < 0) { eP.Alive = false; }

        Debug.Log(eP.Name + $"got attacked ! Leaving him at {eP.HP} HP");
    }

    private void Welcoming(string T)
    {
        Debug.Log($"Welcome, {T} !!");
    }

    private int Max(int a, int b)
    {
        if (a < b)
        {
            return b;
        }
        else
        {
            return a;
        }
    }

    private int BerekenSchade(int aanval, int verdedeging)
    {
        aanval -= verdedeging;
        if (aanval < 0) { aanval = 0; }
        return aanval;
    }

    private void EnemyArray()
    {
        string[] strings = {"Gangar", "Chud", "Agarthan Soldier", "IQ-Maniac"};

        for (int i = 0; i < strings.Length; i++)
        {
            Debug.Log(strings[i]);
        }
    }

    private void EnemyList()
    {
        List<string> name = new List<string>();

        name.Add("Chud");
        name.Add("Goon");
        name.Add("Agarthan Soldier");
        name.Add("IQ-Maniac");

        name.Remove("Chud");

        foreach (string s in name)
        {
            Debug.Log(s);
        }
    }



    void Start()
    {
        Erwin1();
        Welcoming(eP.Name);
        erwinAttacked(0);

        Debug.Log(Max(40,50));
        Debug.Log(Max(4308, 5123));
        Debug.Log(Max(40123333  , 20));

        Debug.Log(BerekenSchade(40, 20));

        EnemyArray();
        EnemyList();
    }

    void Update()
    {
        
    }
}
