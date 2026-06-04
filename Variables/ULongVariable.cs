using UnityEngine;

namespace SOAP.Variables
{
    [CreateAssetMenu(fileName = "ULongVariable", menuName = "Variables/ULongVariable")]
    public class ULongVariable : ScriptableVariable<ulong>
    {
        protected override bool EqualityComparer(ulong a, ulong b)
        {
            return string.Equals(a, b);
        }
    }
}