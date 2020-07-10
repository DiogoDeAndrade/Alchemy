using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Alchemy/Recipe")]
public class Recipe : ScriptableObject
{
    public Item[] items;
    public Color  resultColor;
}
