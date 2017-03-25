using UnityEngine;
using System.Collections;
using Assets.Scripts.Player;
using Assets.Scripts.Auxiliar.MonoEnums;

public class Player : MonoBehaviour {

    private float _walkingSpeed;
    private float _runningSpeed;
    private float _jumpForce;
    private bool _facingRight;
    private bool _transition;

    private BoxCheckpoint[] arrayCaixas;

    private DeathCounter _deathCounter;
    private CheckPoint _lastCheckPoint;
    //private PlayerController _playerController;
    
    public bool IsWalking { get; set; }
    public bool IsRunning { get; set; }
    public bool IsJumping { get; set; }
    public bool IsGrounded { get; set; }
    public bool IsDead { get; set; }

    // Use this for initialization
    void Start () {
        //_walkingSpeed = 3;
        _walkingSpeed = 5;
        _runningSpeed = 5;
        _jumpForce = 1000;

        _deathCounter = DeathCounter.Instance;
        //_lastCheckPoint = new CheckPoint(this.transform.position, 0);
        //_playerController = FindObjectOfType<PlayerController>();

        this.gameObject.AddComponent<CheckPoint>();
        _lastCheckPoint = this.gameObject.GetComponent<CheckPoint>();
        _lastCheckPoint.index = 0;
        _lastCheckPoint.Position = this.transform.position;

        IsWalking = false;
        IsRunning = false;
        IsJumping = false;
        IsGrounded = false;
        IsDead = false;

        arrayCaixas = FindObjectsOfType(typeof(BoxCheckpoint)) as BoxCheckpoint[];
    }
	
	// Update is called once per frame
	void Update () {

    }

    public void Jump()
    {
        if (!IsJumping)
        {
            Rigidbody2D rbPlayer = this.GetComponent<Rigidbody2D>();
            //rbPlayer.velocity = new Vector2(0, _jumpForce);
            rbPlayer.AddForce(new Vector2(0, _jumpForce));

            IsJumping = true;
        }
    }

    public void Walk(float direction)
    {
        transform.Translate(new Vector3(direction * _walkingSpeed * Time.deltaTime, 0, 0));
        IsWalking = (direction != 0);
        IsRunning = false;
        _Flip(direction);
    }

    public void Run(float direction)
    {
        transform.Translate(new Vector3(direction * _runningSpeed * Time.deltaTime, 0, 0));
        IsRunning = (direction != 0);
        IsWalking = false;
        _Flip(direction);
    }

    public void SetCheckpoint(CheckPoint checkPoint)
    {
        if (_lastCheckPoint.index < checkPoint.index)
            _lastCheckPoint = checkPoint;
        
    }
    
    public void Die()
    {
        if (!IsDead)
        {
            IsDead = true;

            //_playerController.enabled = false;
            _deathCounter.IncreaseDeath();
            new WaitForSeconds(0.5f);
            this.transform.position = _lastCheckPoint.Position;
            //_playerController.enabled = true;

            foreach (BoxCheckpoint caixa in arrayCaixas)
            {
                caixa.resetPosition();
            }

            IsDead = false;
        }
    }

    public void ResetDeaths()
    {
        _deathCounter.ResetDeaths();
    }

    private void _Flip(float direction)
    {
        if(direction != 0) {
            Vector3 theScale = transform.localScale;

            if ((theScale.x < 0 && direction > 0) || (theScale.x > 0 && direction < 0))
                theScale.x *= -1;

            transform.localScale = theScale;

        }

    }

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == ETagName.Ground.GetDescription())
		{
			IsJumping = false;
			IsGrounded = true;
		}
	}

	void OnCollisionStay2D(Collision2D col)
	{
		if (col.gameObject.tag == ETagName.Ground.GetDescription())
		{
			IsGrounded = true;
		}
	}

	void OnCollisionExit2D(Collision2D col)
	{
		if (col.gameObject.tag == ETagName.Ground.GetDescription())
		{
			IsGrounded = false;
		}
	}

	/*
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == ETagName.Ground.GetDescription())
        {
            IsJumping = false;
            IsGrounded = true;
        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == ETagName.Ground.GetDescription())
        {
            IsGrounded = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == ETagName.Ground.GetDescription())
        {
            IsGrounded = false;
        }
    }
    */
}
