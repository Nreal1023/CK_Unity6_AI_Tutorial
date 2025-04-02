using System;
using Unity.Behavior;
using UnityEngine;
using Action = Unity.Behavior.Action;
using Unity.Properties;

[Serializable, GeneratePropertyBag]
[NodeDescription(name: "Weapon", story: "Try Attack with [CurrentWeapon]", category: "Action", id: "4621abc2639ae3b48d1e07a1ab651d2b")]
public partial class WeaponAction : Action
{
    [SerializeReference] public BlackboardVariable<WeaponBase> CurrentWeapon;

    protected override Status OnUpdate()
    {
        CurrentWeapon.Value.TryAttack();

        return Status.Success;
    }
}

