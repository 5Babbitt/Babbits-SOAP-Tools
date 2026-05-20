using System;
using UnityEngine;

namespace SOAP.Variables
{
    public class EnumVariable<T> : ScriptableVariable<T> where T : Enum
    {
        protected override bool EqualityComparer(T a, T b)
        {
            return a.Equals(b);
        }
    }
}