using UnityEngine;

public class PlayerAnimationTriggers : MonoBehaviour
{
  private Player player => GetComponentInParent<Player>();
  
  private void AnimationTrigger()
  {
    player.AnimationTrigger();
  }

  private void AttackTrigger()
  {
    var colliders = Physics2D.OverlapCircleAll(player.attackCheck.position, player.attackCheckRadius);
    
    foreach (var hit in colliders)
    {
      if (hit.GetComponent<Enemy>() != null)
        hit.GetComponent<Enemy>().Damage();
    }
  }

  private void ThrowSword()
  {
    SkillManager.instance.sword.CreateSword();
  }
}
