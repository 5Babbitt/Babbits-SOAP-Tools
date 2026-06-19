using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

namespace SOAP.Editor
{
    // Primitive Types
    [CustomPropertyDrawer(typeof(Variables.BoolVariable))]
    public class BoolVariableDrawer : GenericVariableDrawer<Variables.BoolVariable, bool, Toggle> { }
    
    [CustomPropertyDrawer(typeof(Variables.FloatVariable))]
    public class FloatVariableDrawer : GenericVariableDrawer<Variables.FloatVariable, float, FloatField> { }
    
    [CustomPropertyDrawer(typeof(Variables.IntVariable))]
    public class IntVariableDrawer : GenericVariableDrawer<Variables.IntVariable, int, IntegerField> { }
    
    [CustomPropertyDrawer(typeof(Variables.StringVariable))]
    public class StringVariableDrawer : GenericVariableDrawer<Variables.StringVariable, string, TextField> { }
    
    [CustomPropertyDrawer(typeof(Variables.ULongVariable))]
    public class ULongVariableDrawer : GenericVariableDrawer<Variables.ULongVariable, ulong, UnsignedLongField> { }
    
    // Unity Types
    [CustomPropertyDrawer(typeof(Variables.ColourVariable))]
    public class ColourVariableDrawer : GenericVariableDrawer<Variables.ColourVariable, Color, ColorField> { }
    
    [CustomPropertyDrawer(typeof(Variables.Vector2Variable))]
    public class Vector2VariableDrawer : GenericVariableDrawer<Variables.Vector2Variable, Vector2, Vector2Field> { }
    
    [CustomPropertyDrawer(typeof(Variables.Vector3Variable))]
    public class Vector3VariableDrawer : GenericVariableDrawer<Variables.Vector3Variable, Vector3, Vector3Field> { }
    
    [CustomPropertyDrawer(typeof(Variables.Texture2DVariable))]
    public class Texture2DVariableDrawer : GenericVariableDrawer<Variables.Texture2DVariable, Texture2D, ObjectField<Texture2D>> { }
}