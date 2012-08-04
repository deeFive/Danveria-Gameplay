//---------------------------------------------
// Dan Welsh - 2012
// Danveria Acrade Gameplay scrpts
// Pistol Projectile ver 0.01
//---------------------------------------------

// The reference to the explosion prefab
var timeOut = 300.0;

// Kill the rocket after a while automatically
function Start () 
{
	Invoke("Kill", timeOut);
}


function OnCollisionEnter (collision : Collision) 
{
	// Instantiate explosion at the impact point and rotate the explosion
	// so that the y-axis faces along the surface normal
	var contact : ContactPoint = collision.contacts[0];
	var rotation = Quaternion.FromToRotation(Vector3.up, contact.normal);    //Instantiate (contact.point, rotation);

	// And kill our selves
	Kill ();    
}

function Kill () 
{
	// Destroy the projectile
	Destroy(gameObject);
}


@script RequireComponent (Rigidbody)