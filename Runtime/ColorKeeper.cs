using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MixedRealityWorkspace1.ColorData
{
    [CreateAssetMenu(fileName = "NewColor", menuName = "ScriptableObjects/ObjectColor", order = 1)]
    public class ColorKeeper : ScriptableObject
    {
        [SerializeField] Color _myColor;

        public Color MyColor { get => _myColor; set => _myColor = value; }
    }
}
