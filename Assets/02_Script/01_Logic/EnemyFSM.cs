using System.Linq;
using UnityEngine;
using UnityEngine.AI;
using Unity.Behavior;

public class EnemyFSM : MonoBehaviour
{
    private Transform target;
    private NavMeshAgent navMeshAgent;
    private BehaviorGraphAgent behaviorAgent;

    public void Setup(Transform target, GameObject[] wayPoints)
    {
        this.target = target;

        navMeshAgent = GetComponent<NavMeshAgent>();
        behaviorAgent = GetComponent<BehaviorGraphAgent>();
        navMeshAgent.updateRotation = false;
        navMeshAgent.updateUpAxis = false;

        behaviorAgent.SetVariableValue("PatrolPoints", wayPoints.ToList());
        behaviorAgent.SetVariableValue("Target", target.gameObject);
    }
}

