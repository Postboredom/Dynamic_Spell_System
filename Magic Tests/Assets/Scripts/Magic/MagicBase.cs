using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicBase : Magic_interface
{
    public GameObject obj;

    
  
    public GameObject SpawnItem()
    {
        obj = GameObject.Find("Magic Spawn");
        return obj;
    }
}
