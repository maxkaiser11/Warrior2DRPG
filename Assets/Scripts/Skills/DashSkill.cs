using UnityEngine;

public class DashSkill : Skill
{
    public override void UseSkill()
    {
        base.UseSkill();
        
        Debug.Log("created clone behind");
    }
}
