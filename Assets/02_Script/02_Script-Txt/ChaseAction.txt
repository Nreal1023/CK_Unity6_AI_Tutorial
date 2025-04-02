using System;
using Unity.Behavior;
using UnityEngine;
using Action = Unity.Behavior.Action;
using Unity.Properties;
using UnityEngine.AI;

[Serializable, GeneratePropertyBag]
[NodeDescription(name: "Chase", story: "[Self] Navigate To [Target]", category: "Action", id: "d96d2f1d8bf2601c2bc57b68be0a89c0")]
public partial class ChaseAction : Action
{
    [SerializeReference] public BlackboardVariable<GameObject> Self;
    [SerializeReference] public BlackboardVariable<GameObject> Target;

    private NavMeshAgent agent;

    protected override Status OnStart()
    {
        agent = Self.Value.GetComponent<NavMeshAgent>();
        agent.speed = 5f;
        agent.SetDestination(Target.Value.transform.position);

        return Status.Running;
    }
}

