using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeBase : MonoBehaviour

{
    public bool isDead;

    protected float health;

}

public struct Quest
{
    public string name;
    public int id;
    public string title;
    public string description;
}

public class Heroe : PersonajeBase
{
    private Quest quest;

    public void setQuest(string _name, string _description, string _title)
    {
        quest.id = Random.Range(0, 50);
        quest.name = _name;
        quest.title = _description;
        quest.description = _title;
    }

    public Quest GetQuest()
    {
        return quest;
    }
}