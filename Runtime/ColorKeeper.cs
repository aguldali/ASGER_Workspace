using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MixedRealityWorkspace1.ColorSystem
{
    [CreateAssetMenu(fileName = "NewColor", menuName = "ScriptableObjects/ObjectColor", order = 1)]
    public class ColorKeeper : ScriptableObject
    {
        [SerializeField] Color myColor;
        public Color MyColor { get => myColor; set => myColor = value; }

    }
}

    
