using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum ItemType
{ 
    carne,
    pocion,
    libro
}

public class Inventario : MonoBehaviour
{
    public static Inventario instance;
    public Item[] items;
    private void Awake()
    {
        instance = this;
    }
}

public class Item
{
    public bool isFull;
    public int amount;
    public ItemType type;
    public string name;
    public GameObject slotSprite;
}
