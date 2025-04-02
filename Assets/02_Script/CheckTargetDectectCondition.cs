using System;
using Unity.Behavior;
using UnityEngine;

[Serializable, Unity.Properties.GeneratePropertyBag]
[Condition(name: "CheckTargetDectect", story: "Compare values of [CurrentDistance] and [ChaseDistance]", category: "Conditions", id: "44e2ec00698cb0244d83a3017c1aded2")]
public partial class CheckTargetDectectCondition : Condition
{
    [SerializeReference] public BlackboardVariable<float> CurrentDistance;
    [SerializeReference] public BlackboardVariable<float> ChaseDistance;

    public override bool IsTrue()
    {
        if (CurrentDistance.Value <= ChaseDistance.Value)
        {
            return true;
        }

        return false;
    }
}
