using System.Linq;
using UnityEngine;
using UnityEngine.AI;
using Unity.Behavior;

public class EnemyFSM : MonoBehaviour
{
    [SerializeField]
    private float cooldowmTime = 2f;
    [SerializeField]
    private float damage = 10f;

    private Transform target;
    private NavMeshAgent navMeshAgent;
    private BehaviorGraphAgent behaviorAgent;
    private WeaponBase currentWeapon;   // 현재 활성화된 무기

    public void Setup(Transform target, GameObject[] wayPoints)
    {
        this.target = target;

        navMeshAgent = GetComponent<NavMeshAgent>();
        behaviorAgent = GetComponent<BehaviorGraphAgent>();
        currentWeapon = GetComponent<WeaponBase>();

        navMeshAgent.updateRotation = false;
        navMeshAgent.updateUpAxis = false;

        behaviorAgent.SetVariableValue("PatrolPoints", wayPoints.ToList());
        behaviorAgent.SetVariableValue("Target", target.gameObject);

        currentWeapon.Setup(target, damage, cooldowmTime);
    }
}

