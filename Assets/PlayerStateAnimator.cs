using States;
using States.Player;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerStateAnimator : MonoBehaviour {
    private Animator _animator;
    private static readonly int PlayerState = Animator.StringToHash("PlayerState");
    private static readonly int ChangeState = Animator.StringToHash("State Change");

    public void Awake() {
        _animator = GetComponent<Animator>();
    }

    public void Trigger(State state) {
        MovableState playerState = (MovableState) state;
        int playerStateType = (int) playerState.PlayerState;
        if (state.phase == Phase.Start) {
            Debug.Log(playerStateType);
            _animator.SetInteger(PlayerState, playerStateType);
            _animator.SetTrigger(ChangeState);
        }
    }
}
