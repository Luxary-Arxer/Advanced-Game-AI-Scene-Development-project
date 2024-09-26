using UnityEngine;

using Pada1.BBCore;
using Pada1.BBCore.Framework;

[Condition("MyConditions/Is SantaClausClose????")]
[Help("Checks whether the King is close to SANTA CLOUSE.")]
public class Is_King_to_far : ConditionBase
{
    public override bool Check()
    {
        GameObject SantaClaus = GameObject.Find("Santa Claus");
        GameObject King = GameObject.Find("King_Only Model");
        return Vector3.Distance(SantaClaus.transform.position, King.transform.position) < 40f;
    }
}
