using UnityEngine;

[CreateAssetMenu]
public class SampleScriptableObject : ScriptableObject
{
    public bool var1;
    [EnableIf(nameof(var1), true)]
    public int var2;
}