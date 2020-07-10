using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mixer : MonoBehaviour
{
    public ItemSlot[]   itemSlot;
    public Image        liquid;
    public Recipe[]     recipes;

    void Update()
    {
        bool  firstColor = true;
        Color color = Color.black;

        Recipe recipe = GetRecipe();
        if (recipe)
        {
            color = recipe.resultColor;
        }

        liquid.color = color;
    }

    Recipe GetRecipe()
    {
        foreach (var r in recipes)
        {
            bool match = true;
            for (int i = 0; i < r.items.Length; i++)
            {
                if (itemSlot[i].GetItem() != r.items[i])
                {
                    match = false;
                    break;
                }
            }
            if (match)
            {
                return r;
            }
        }

        return null;
    }
}
