using UnityEngine;
using System.Collections;

public class AnimationController : MonoBehaviour {

    public Animator animator;
    private Player _player;
    private Rigidbody2D _rbPlayer;

    void Start()
    {
        _player = FindObjectOfType<Player>();
        _rbPlayer = _player.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (!_player.IsDead)
        {
            animator.SetBool("walk", _player.IsWalking);
            animator.SetBool("running", _player.IsRunning);
            animator.SetBool("isJumping", _player.IsJumping);
            animator.SetFloat("speedY", _rbPlayer.velocity.y);
        }
    }
}
