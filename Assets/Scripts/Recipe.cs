using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Recipe", menuName = "ScriptableObjects/Recipe")]
public class Recipe : ScriptableObject {
    [SerializeField] private string recipeName;

    [SerializeField] private string outcomeName;

    [SerializeField] private string[] ingredients = {null, null, null, null, null, null, null, null, null};

    public string CheckAgainstRecipe(string[] input) {
        for (int i = 0; i < 9; i++) { 
            if(input[i] != ingredients[i]) {
                return null;
            }
        }
        return recipeName;
    }
}
