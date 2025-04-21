using UnityEngine;

public class PlayerJumpState : PlayerState
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public PlayerJumpState(Player _player, PlayerStateMachine _stateMachine, string _animBoolName) : base(_player, _stateMachine, _animBoolName)
    {
    }

    public override void Enter()
    {
        base.Enter();

        rb.linearVelocity = new Vector2(rb.linearVelocity.x, player.jumpForce);
    }

    public override void Exit()
    {
        base.Exit();
    }
    
    public override void Update()
    {
        base.Update();
        
        if (rb.linearVelocity.y < 0)
            stateMachine.ChangeState(player.airState);
    }

}
