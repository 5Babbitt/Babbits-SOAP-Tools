using System;
using UnityEngine;

namespace SOAP.Variables
{
    [CreateAssetMenu(fileName = "EnumVariable", menuName = "Variables/EnumVariable")]
    public class EnumVariable<T> : ScriptableVariable<T> where T : Enum
    {
        protected override bool EqualityComparer(T a, T b)
        {
            return a.Equals(b);
        }
    }
}