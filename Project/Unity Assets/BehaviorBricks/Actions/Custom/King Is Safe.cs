using UnityEngine;
 
using Pada1.BBCore;
using Pada1.BBCore.Framework; 

[Condition("MyConditions/King SAFE ???")]
[Help("Is Safe")]
public class Kings_SAFE : ConditionBase
{
    public float test;

    public override bool Check()
    {
        GameObject Kings_Guard = GameObject.Find("Leader_King Guard");
        GameObject Guardians = GameObject.Find("Kings Guard");
        return Vector3.Distance(Kings_Guard.transform.position, Guardians.transform.position) < 1.0f;
    }
} 
