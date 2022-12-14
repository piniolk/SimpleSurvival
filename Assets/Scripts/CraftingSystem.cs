using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftingSystem : MonoBehaviour {
    public GameObject[] craftingSlots = new GameObject[9];
    string[] craftingSlotNames = {null, null, null, null, null, null, null, null, null };
    Dictionary<int, Recipe> validRecipes = new Dictionary<int, Recipe>();
    
    public void CheckRecipes() {
        if (validRecipes.Count > 0) {
            foreach(Recipe recipe in validRecipes.Values) {
                recipe.CheckAgainstRecipe(craftingSlotNames);
            }
        }
    }


}
