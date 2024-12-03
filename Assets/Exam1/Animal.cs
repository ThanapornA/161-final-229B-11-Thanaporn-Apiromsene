using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    protected string animalName;

    public string DoingWhat;
    public string Sound;
    public float FoodConsumption;

    public int ActLvl;
    public float WeiNum;

    //Dog
    public void Init( string newName , string newSound , float foodConsumption , string doingWhat , int newActLvl )
    {
        animalName = newName;
        DoingWhat = doingWhat;
        Sound = newSound;
        FoodConsumption = foodConsumption;

        ActLvl = newActLvl;
    }

    //Bird
    public void Init(string newName, string newSound, float foodConsumption, string doingWhat , float newWeiNum)
    {
        animalName = newName;
        DoingWhat = doingWhat;
        Sound = newSound;
        FoodConsumption = foodConsumption;

        WeiNum = newWeiNum;
    }

    public abstract float CalculateFoodRequirement();

    public virtual void MakeSound()
    {
        Debug.Log($"The animal makes a sound.");
    }

    public void DisplayName()
    {
        Debug.Log($"This is a {animalName}.");
    }
}
