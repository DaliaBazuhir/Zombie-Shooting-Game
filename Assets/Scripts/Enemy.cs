using UnityEngine;
using UnityEngine.AI;
public class Enemy : MonoBehaviour
{
    [SerializeField] Transform player;
    NavMeshAgent navMeshAgent;
    bool isProvoked = false;
    float distanceToPlayer = 0;
    float chaseRange =10f;
    Animator animator;
    void Awake()
    {
       navMeshAgent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
        distanceToPlayer = Vector3.Distance(player.position,transform.position);
        if(isProvoked){
            AttackThePlayer();
        }
        if(distanceToPlayer<chaseRange){
            isProvoked = true;
        }
    }
    private void AttackThePlayer () {
        if(distanceToPlayer>= navMeshAgent.stoppingDistance){
            ChaseThePlayer();
        }else if(distanceToPlayer<= navMeshAgent.stoppingDistance){
            ShootTarget();
        }
    }
    private void ChaseThePlayer () {
         animator.SetBool("attack",false);
         animator.SetTrigger("move");
         navMeshAgent.SetDestination(player.position);

    }
    private void ShootTarget () {
         animator.SetBool("attack",true);
    }
    private void OnDrawGizmosSelected() {
        Gizmos.DrawWireSphere(transform.position,chaseRange);
    }
    
}
