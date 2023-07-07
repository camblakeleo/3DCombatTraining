using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class EnemyFollows : MonoBehaviour
{ 
     #region Variables
     private NavMeshAgent agent;  // A reference to the NavMesh component of the Enemy game object
     public Transform target;     // reference to the Transform of the game object we want the enemy to follow 
     #endregion



    // Awake is called on the first frame this game object enters the scene
    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.position);   // sets the destination of the enemy to the position of its target every frame
    }
}
