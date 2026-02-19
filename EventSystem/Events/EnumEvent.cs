using System;
using UnityEngine;

namespace _Scripts.SOAP.EventSystem.Events
{
    [CreateAssetMenu(menuName = "Events/Enum Event")]
    public class EnumEvent<T> : GameEvent<T> where T : Enum { }
}