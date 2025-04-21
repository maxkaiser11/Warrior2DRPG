using UnityEngine;

public class PlayerAirState : PlayerState
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public PlayerAirState(Player _player, PlayerStateMachine _stateMachine, string _animBoolName) : base(_player, _stateMachine, _animBoolName)
    {
    }

    public override void Enter()
    {
        base.Enter();
    }
    
    public override void Exit()
    {
        base.Exit();
    }

    public override void Update()
    {
        base.Update();
        
        if (player.IsWallDetected())
            stateMachine.ChangeState(player.wallSlide);
        
        if(player.IsGroundDetected())
            stateMachine.ChangeState(player.idleState);
        
        if (xInput != 0)
            player.SetVelocity(player.moveSpeed * .8f * xInput, rb.linearVelocity.y);
    }
}
