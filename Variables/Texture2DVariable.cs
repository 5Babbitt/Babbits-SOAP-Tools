using UnityEngine;

namespace SOAP.Variables
{
    [CreateAssetMenu(fileName = "Texture2DVariable", menuName = "Variables/Texture2DVariable")]
    public class Texture2DVariable : ScriptableVariable<Texture2D>
    {
        protected override bool EqualityComparer(Texture2D a, Texture2D b)
        {
            return a == b;
        }
    }
}