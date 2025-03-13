using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
     
   PlayerHealth player;
    public int damage = 10;
    void Start(){
       player = FindObjectOfType<PlayerHealth>();
    }
    public void AttackHitEvent () {
        if(player == null) return;
      
        player.TakeDamage(damage);
    } 
}
