using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Magic_Decorator : Magic_interface
{
    private Magic_interface _magic;

    public Magic_Decorator(Magic_interface magic)
    {
        _magic = magic;
    }

    public virtual GameObject SpawnItem()
    {
       return _magic.SpawnItem();
    }

}
