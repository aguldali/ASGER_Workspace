using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MixedRealityWorkspace1.ColorSystem;

    public class ObjectColorController : MonoBehaviour
    {
        Material objectMaterial;

        private void Start()
        {
            objectMaterial = GetComponent<MeshRenderer>().material;
        }

        public void ChangeColor(ColorKeeper objectColor)
        {
            objectMaterial.color = objectColor.MyColor;
        }

    }
