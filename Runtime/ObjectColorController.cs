using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MixedRealityWorkspace1.ColorData;

public class ObjectColorController : MonoBehaviour
{
    Material _objectMaterial;

    private void Start()
    {
        _objectMaterial = GetComponent<MeshRenderer>().material;
    }

    public void ChangeColor(ColorKeeper objectColor)
    {
        _objectMaterial.color = objectColor.MyColor;
    }

}
