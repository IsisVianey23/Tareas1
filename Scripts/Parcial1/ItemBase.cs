using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class  ItemBase : MonoBehaviour
{
    Inventario inventario;
    public string nameItem;
    public Itemtype type;
    public Sprite sprite;


    
    void Start()
    {
        inventario = Inventario.instance;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag-- "Player")
        {
                if (inventario.items[i].isFull = false)
                {
                    Debug.Log("Item Añadido");
                    inventario.items[i].isFull = true;
                    Destroy(gameObject);
                    Break;
                }
            
        }
    }
}
