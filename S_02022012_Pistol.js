//---------------------------------------------
// Dan Welsh - 2012
// Danveria Acrade Gameplay scrpts
// Pistol ver 0.01
//---------------------------------------------

var projectile : Rigidbody;
var initialSpeed = 200;// 
var reloadTime = 0.5;//
var ammoCount = 300;//300 round in standard clip
private var lastShot = -10.0;

function Fire () 
{
	// Did the time exceed the reload time?
	if (Time.time > reloadTime + lastShot && ammoCount > 0) 
	{
		// create a new projectile, use the same position and rotation as the Launcher.
		var instantiatedProjectile : Rigidbody = Instantiate (projectile, transform.position, transform.rotation);
			
		// Give it an initial forward velocity. The direction is along the y-axis (its the axis that is facing forward) of the pistol's transform.
		instantiatedProjectile.velocity = transform.TransformDirection(Vector3 (0, initialSpeed, 0));

		// Ignore collisions between the missile and the character controller
		Physics.IgnoreCollision(instantiatedProjectile.collider, transform.root.collider);
		
		lastShot = Time.time;
		ammoCount--;
	}
}