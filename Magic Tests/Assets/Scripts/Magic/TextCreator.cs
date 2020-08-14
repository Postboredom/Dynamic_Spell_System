using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextCreator : MonoBehaviour
{
    int counter = 0;
    public Text Spell;
    Magic_interface magic;
    private void Start()
    {
        magic = new MagicBase();
        Spell.text = "";
    }

    public void AddSpell(string spell)
    {
        counter++;

        Spell.text += counter + ") " + spell + ", ";

        Setspell(spell);
    }

    public void Setspell(string spell)
    {
        if (spell.Contains("cube"))
        {
            magic = new Spawn_Cube(magic);
        }

        if (spell.Contains("sphere"))
        {

            magic = new Spawn_Circle(magic);
        }

    }

    public void CastSpell()
    {
        magic.SpawnItem();
    }
}
