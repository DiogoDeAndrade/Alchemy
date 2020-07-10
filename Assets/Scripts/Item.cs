using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Alchemy/Item")]
public class Item : ScriptableObject
{
    public Sprite image;
    public Color  color = Color.white;
}
