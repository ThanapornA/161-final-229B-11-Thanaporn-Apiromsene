using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    private float dailyFoodConsumption;
    private int activityLevel;

    private void Start()
    {
        Init("Dog", "Woof", 0.5f, "barks", 3);
        activityLevel = ActLvl;
        dailyFoodConsumption = FoodConsumption;

        DisplayName();
        MakeSound();
        Debug.Log($"{animalName} {DoingWhat} : {Sound} !");
        Print();
        CalculateFoodRequirement();
        Debug.Log($"----------------------------");
    }
    public override float CalculateFoodRequirement()
    {
        float foodConsumptionCalculated = dailyFoodConsumption * activityLevel * 7;
        Debug.Log($"{animalName}'s weekly food requirement : {foodConsumptionCalculated}kg.");
        return foodConsumptionCalculated;
    }

    public void Print()
    {
        Debug.Log($"{animalName} eats {FoodConsumption}kg. of food daily with activity level {activityLevel}.");
    }
}
