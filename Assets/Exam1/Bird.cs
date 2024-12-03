using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : Animal
{
    private float dailyFoodConsumption;
    private float weight;

    private void Start()
    { 
        Init("Bird" , "Tweet" , 0.1f , "chrips" , 0.5f );
        weight = WeiNum;

        DisplayName();
        MakeSound();
        Debug.Log($"{animalName} {DoingWhat} : {Sound} !");
        Print();
        CalculateFoodRequirement();
        Debug.Log($"----------------------------");
    }

    public override float CalculateFoodRequirement()
    {
        float foodConsumptionCalculated = dailyFoodConsumption * weight * 7;
        Debug.Log($"{animalName}'s weekly food requirement : {foodConsumptionCalculated}kg.");
        return foodConsumptionCalculated;
    }

    public void Print()
    {
        Debug.Log($"{animalName} eats {FoodConsumption}kg. of food daily and weighs {weight}kg.");
    }
}
