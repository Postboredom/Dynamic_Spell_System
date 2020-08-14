using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.VFX;


public class Test_Spell_Spawn : MonoBehaviour
{
    GameObject obj;
    GameObject meshToSDF;
    MeshToSDF particles;
    VisualEffect myEffect;
    Magic_interface _spell;
    public GameObject meshToSDFPrefab;
    public VisualEffectAsset[] effects;
    static readonly string objPos = "Pos";

    private void Awake()
    {
        Debug.Log(effects.Length);
    }

    // Start is called before the first frame update
    void Start()
    {
        obj = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        meshToSDF = Instantiate(meshToSDFPrefab);
        meshToSDF.transform.parent = obj.transform;
        obj.GetComponent<MeshRenderer>().enabled = false;
        obj.transform.position = Vector3.zero;
        AddVFX();
        AddSDF();
    }

    public void AddSDF()
    {
        particles = meshToSDF.GetComponent<MeshToSDF>();
        particles.mesh = obj.GetComponent<MeshFilter>().mesh;
        particles.vfxOutput = myEffect;      
    }

    public void AddVFX()
    {

        obj.AddComponent<VisualEffect>();
        myEffect = obj.GetComponent<VisualEffect>();
        myEffect.visualEffectAsset = effects[Random.Range(0, effects.Length-1)];
        myEffect.SetVector3(objPos, obj.transform.position);

    }
}
