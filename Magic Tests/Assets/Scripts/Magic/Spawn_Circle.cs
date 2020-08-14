using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.VFX;

public class Spawn_Circle : Magic_Decorator
{
    public GameObject obj;
    public Transform pos;
    MeshToSDF particles;
    VisualEffect myEffect;
    Magic_interface _spell;
    static readonly string objPos = "Pos";



    public Spawn_Circle(Magic_interface magic) : base(magic) { }

    public override GameObject SpawnItem()
    {
        obj = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        //Object.Instantiate(obj, base.SpawnItem().transform);
        obj.transform.position = Vector3.zero;
        AddSDF();
        AddVFX();     
        return obj;
    }

    public void AddSDF()
    {
        obj.AddComponent<MeshToSDF>();
        particles = obj.GetComponent<MeshToSDF>();
        particles.mesh = obj.GetComponent<MeshFilter>().mesh;
    }

    public void AddVFX()
    {

        obj.AddComponent<VisualEffect>();
        obj.GetComponent<VisualEffect>();
        myEffect = obj.GetComponent<VisualEffect>();
        myEffect.SetVector3(objPos, obj.transform.position);

}
}
