using UnityEngine;
 
using Pada1.BBCore;
using Pada1.BBCore.Framework; 

[Condition("MyConditions/Is King Guard Near?")]
[Help("Checks whether King has Guad close.")]
public class IsKingsGuard : ConditionBase
{
    public float test;

    public override bool Check()
    {
        GameObject Kings_Guard = GameObject.Find("Leader_King Guard");
        GameObject Claus = GameObject.Find("Santa Claus");
        return Vector3.Distance(Kings_Guard.transform.position, Claus.transform.position) < 20f;
    }
} 
