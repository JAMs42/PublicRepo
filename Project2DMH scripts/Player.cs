using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
	Animator anim;
	public Camera playerCamera;
	
	private bool doubleJump = false;
	private float maxSpeed = 15f;
	private float jumpForce = 900f;
	private float move;
	private bool facingRight = true;
	private bool gotHit = false;
	
	//dash related variables
	private float dashForce = 10000f;
	private float dashCD = 1f;
	private float dashCDT = 0f;
	
	//ground check related variables
	private bool onGround = false;
	private float groundRadius = 0.2f;
	public Transform groundCheck;
	public LayerMask whatIsGround;
	
	//wall check related variables
	private bool againstWall = false;
	private float wallCheckRadius = 0.2f;
	public Transform wallCheck;
	public LayerMask whatIsWall;
	
	//shooting related variables
	public GameObject bulletPrefab;
	private bool shooting = false;
	private float shootCDT;
	private float fireRate = 0.25f;
	private float bulletSpeed = 1500f;
	
	//direction from player to mouse variables
	private float angle;
	private const float angleRange = 45f;
	private Vector3 mousePosition;
	private Vector3 mouseWorldPosition;
	private Vector3 direction;
	
	//temporary data
	public static int hitPoints = 10;
	
	void Start()
	{
		hitPoints = 10;
		anim = GetComponent<Animator>();
		anim.SetInteger( "Hit Points", hitPoints );
	}
	
	//FixedUpdate is for data that demands accuracy as it "can" run multiple times per frame
	void FixedUpdate()
	{
		angle = getPlayerToMouseAngle();
		
		//ground/jump check
		onGround = Physics2D.OverlapCircle( groundCheck.position, groundRadius, whatIsGround );  //checks if groundCheck has hit anythingr
		anim.SetBool( "onGround", onGround );													 //lets animator if were on ground or not
		anim.SetFloat( "vSpeed", rigidbody2D.velocity.y );										 //lets animator know of our vertical speed
		
		//against wall check
		againstWall = Physics2D.OverlapCircle( wallCheck.position, wallCheckRadius, whatIsWall );
		anim.SetBool( "againstWall", againstWall );
		
		//move player horizontally
		//move = Input.GetAxis( "Horizontal" );
		move = 1f;
		anim.SetFloat( "Speed", Mathf.Abs( move ) );											//lets animator know our current horizontal speed
		rigidbody2D.velocity = new Vector2( move * maxSpeed, rigidbody2D.velocity.y );			//moves sprite horizontally while left or right inputs are held

		//flip sprite to face right
		if( move > 0 && !facingRight && !shooting)
		{
			Flip();
		}
		//flip sprite to face left
		else if( move < 0 && facingRight && !shooting)
		{
			Flip();
		}
		
		if( onGround )
		{
			doubleJump = false;
		}
		
		//jump
		if( ( onGround || !doubleJump ) && Input.GetButtonDown( "Jump" ) )
		{
			anim.SetBool( "onGround", false );								//lets animator know were no longer on the ground
			
			rigidbody2D.velocity = new Vector2( rigidbody2D.velocity.x, 0 );
			rigidbody2D.AddForce( new Vector2( 0, jumpForce ) );
			
			if( !onGround )
			{
				doubleJump = true;
			}
		}
		
		Dash();
		
		//lets animator know if we got hit
		if( gotHit )
		{
			anim.SetBool( "gotHit", gotHit );
		}
		else
		{
			anim.SetBool( "gotHit", gotHit );
		}
		
		//shoot
		if( Input.GetButtonDown( "Fire1" ) )
		{
			Shoot( angle );
		}
		
		//rapid fire
		if( Input.GetButton( "Fire1") )
		{
			Shoot( angle );
			anim.SetBool( "rapidFire", true );
		}
		else
		{
			anim.SetBool( "rapidFire", false );
		}
	}

	//Update is called once per frame
	void Update()
	{
		mousePosition = Input.mousePosition;
//		DrawLine( transform.position, mousePosition, Color.red );
		
		anim.SetInteger( "Hit Points", hitPoints );							//lets animator know our current health
		
		if( Input.GetButtonUp( "Dash" ) )
		{
			anim.SetBool( "Dash", false );									//lets animator know where no longer dashing
		}
		
		if ( Input.GetButtonUp( "Fire1" ) )									//lets animator know were no longer shooting
		{
			shooting = !shooting;
			anim.SetBool( "Fire", false );
		}
		
		if( dashCDT > 0f )
		{
			dashCDT -= Time.deltaTime;											//reduce dash cooldown timer
		}
		
		if( shootCDT > 0f )
		{
			shootCDT -= Time.deltaTime;
		}
	}
	
	void Shoot( float angle )
	{
		if( shootCDT < 0.01f )
		{
			GameObject bullet =  Instantiate( bulletPrefab ) as GameObject;					//creates the bullet object
			bullet.transform.position = transform.position;									//sets bullet spawn to player
			shootCDT = fireRate;
			bullet.transform.rotation = Quaternion.AngleAxis( angle, Vector3.forward ); 	//fire in proper direction
			bullet.rigidbody2D.AddForce( bullet.transform.right * bulletSpeed );               	//apply force
			anim.SetBool( "Fire", true );													//lets animator know were firing
			shooting = true;

			//flip sprite to face right
			if( angle > 90 && facingRight && shooting )
			{
				Flip();
			}
			//flip sprite to face left
			else if( angle < 90 && !facingRight && shooting )
			{
				Flip();
			}
		}
	}
	
	void Dash()
	{
		//dash
		if( dashCDT < 0.01f )													//if dash is off cooldown
		{
			if( Input.GetButtonDown( "Dash" ) )
			{
				anim.SetBool( "Dash", true );									//lets animator know were dashing
				
				if( facingRight )
				{
					rigidbody2D.AddForce( new Vector2( dashForce, 0 ) );
				}
				else if( !facingRight )
				{
					rigidbody2D.AddForce( new Vector2( -dashForce, 0 ) );
				}
				dashCDT = dashCD;												//set dash on cooldown
			}
		}
	}

	//handles flipping sprite horizontally
	void Flip()
	{
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
	
	void ResetMousePointedFlags()
	{
		anim.SetBool( "mousePointedUp", false );
		anim.SetBool( "mousePointedUpDiag", false );
		anim.SetBool( "mousePointedForward", false );
		anim.SetBool( "mousePointedDownDiag", false );
		anim.SetBool( "mousePointedDown", false );
	}
	
	//gets player to mouse angle and aims our player in that direction
	public float getPlayerToMouseAngle()
	{
		mousePosition.z = ( transform.position.z - playerCamera.transform.position.z );		//distance from camera to player	
		mouseWorldPosition = Camera.main.ScreenToWorldPoint ( mousePosition );				//convert to world coordinates
		direction = mouseWorldPosition - transform.position;
		angle = Mathf.Atan2( direction.y, direction.x ) * Mathf.Rad2Deg;					//get the angle and convert from radians to degrees

		//forward *right*
		if( angle <= angleRange * 0.5 && angle >= 0f || angle >= -angleRange * 0.5 && angle <= 0f )
		{
			if( !facingRight )
			{
				Flip();
			}
			ResetMousePointedFlags();
			anim.SetBool( "mousePointedForward", true );
			angle = 0f;
			
			return angle;
		}
		
		//up diagonal *right*
		if( angle <= angleRange * 1.5 && angle >= angleRange * 0.5 )
		{
			if( !facingRight )
			{
				Flip();
			}
			ResetMousePointedFlags();
			anim.SetBool( "mousePointedUpDiag", true );
			angle = 45f;
			
			return angle;
		}
		
		//up
		if( angle <= angleRange * 2.5 && angle >= angleRange * 1.5 )
		{
			ResetMousePointedFlags();
			anim.SetBool( "mousePointedUp", true );
			angle = 90f;
			
			return angle;
		}
		
		//up diagonal *left*
		if( angle <= angleRange * 3.5 && angle >= angleRange *  2.5 )
		{
			if( facingRight )
			{
				Flip();
			}
			ResetMousePointedFlags();
			anim.SetBool( "mousePointedUpDiag", true );
			angle = 135f;
			
			return angle;
		}
		
		//forward *left*
		if( angle <= angleRange * 4 && angle >= angleRange * 3.5 || angle >= angleRange * -4 && angle <= angleRange *  -3.5 )
		{
			if( facingRight )
			{
				Flip();
			}
			ResetMousePointedFlags();
			anim.SetBool( "mousePointedForward", true );
			angle = 180f;
			
			return angle;
		}
		
		//down diagonal *left*
		if( angle <= angleRange * -2.5 && angle >= angleRange * -3.5 )
		{
			if( facingRight )
			{
				Flip();
			}
			ResetMousePointedFlags();
			anim.SetBool( "mousePointedDownDiag", true );
			angle = 225f;
			
			return angle;
		}
		
		//down
		if( angle <= angleRange * -1.5 && angle >= angleRange * -2.5 )
		{
			ResetMousePointedFlags();
			anim.SetBool( "mousePointedDown", true );
			angle = 270f;
			
			return angle;
		}
		
		//down diagonal *right*
		if( angle <= angleRange * -0.5 && angle >= angleRange * -1.5 )
		{
			if( !facingRight )
			{
				Flip();
			}
			ResetMousePointedFlags();
			anim.SetBool( "mousePointedDownDiag", true );
			angle = 315f;
			
			return angle;
		}

		return angle;
	}
	
	public static void Hit( int damage )
	{
		hitPoints -= 1;
		
		if( hitPoints <= 0 )
		{
			Application.LoadLevel( "Game" );
			return;
		}
	}
}