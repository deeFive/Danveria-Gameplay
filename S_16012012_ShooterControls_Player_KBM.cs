//---------------------------------------------
// Dan Welsh - 2012
// Danveria Acrade Control scrpts
// Shooter - Player ver 0.01
//---------------------------------------------


using UnityEngine;
using System.Collections;

public class S_16012012_ShooterControls_Player_KBM : MonoBehaviour 

{

    #region Datastore

    public float WalkSpeed = 100.0f;

    


    #endregion


    #region States
    enum State
    {
        Standing,
        Walking,
        Sprinting,
        Jumping,
        Aiming,
        Shooting,
        Melee,
        LightHit,
        MediumHit,
        HeavyHit

    }

    private State state = State.Standing;

    #endregion


    #region Functions
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //We need to set a default player position
        //we will need to talk to the player position and set it to this deafult
        //position
        
        //here we will set player controls that will be used for the demo 
        //these may well need to made into on/off style switches
        //As this is a 3 way switch we will need to check what state the player is in
        //and if it is already in the Aiming State then we will need move the player to 
        //its default psoition/state

        #region Aiming


        //change player to the aiming position
        if (Input.GetKeyDown("mouse 1"))
        {
            //logic check to what state the player shold be in
            Debug.Log("player should be in Aiming state");
            
            //Move player arms to the Aim stance
            

            //we now need to change the players state to Aiming
            state = State.Aiming;
        }

        if (Input.GetKeyUp("mouse 1"))
        {
            //logic check to see where player should be
            Debug.Log("Camera should be out of Aiming state");

            //Move player arms back from the aim stance

            //we now need to change the cameras state to Aiming
            state = State.Walking;
        }

        #endregion

        #region Walking


        if (Input.GetKeyDown("w"))
        {
            //Logic check to see what the player should be doing
            Debug.Log("player should be in the Walking state");

            //Move player
            //create store for forward movement
            float Forward = Input.GetAxis("Vertical") * WalkSpeed;

            Forward *= Time.deltaTime;
            //Check current forward speed
            Debug.Log("current speed" + Forward);

            transform.Translate(0, 0, Forward);
            

            //transform.Translate(0, 0, 10);

            //change players state to walking
            state = State.Walking;
        }

        if (Input.GetKeyUp("w"))
        {
            //Logic check to see what the player should be doing
            Debug.Log("player should be out of the Walking state");

            //Stop moving player


            //change players state to Standing
            state = State.Standing;
        }

        if (Input.GetKeyDown("s"))
        {
            //Logic check to see what the player should be doing
            Debug.Log("Player should be walking backwards");
 
            //Move player backwards
 
            //Change players State to walking
            state = State.Walking; 
        }

        if (Input.GetKeyUp("s"))
        {
            //Logic check to see what the player should be doing
            Debug.Log("player should be out of the Walking state");

            //Stop moving player


            //change players state to Standing
            state = State.Standing;
        }

        if (Input.GetKeyDown("a"))
        {
            //Logic check to see what the player should be doing
            Debug.Log("player should be walking left");

            //Move player left

            //Change players state to walkikng
            state = State.Walking;
        }

        if (Input.GetKeyUp("a"))
        {
            //Logic check to see what the player should be doing
            Debug.Log("player should be out of the Walking state");

            //Stop moving player


            //change players state to Standing
            state = State.Standing;
        }

        if (Input.GetKeyDown("d"))
        {
            //Logic check to see what the player should be doing
            Debug.Log("player should be walking Right");

            //Move player Right

            //Change players state to walkikng
            state = State.Walking;
        }

        if (Input.GetKeyUp("d"))
        {
            //Logic check to see what the player should be doing
            Debug.Log("player should be out of the Walking state");

            //Stop moving player


            //change players state to Standing
            state = State.Standing;
        }

        #endregion


        //Sprint
        if (Input.GetKeyDown("left shift"))
        {
            //logic check to see where camera should be
            Debug.Log("Camera should be in ADS state");
            
            //we now need to change the cameras state to ADS
            state = State.Sprinting;
        }

        if (Input.GetKeyUp("left shift"))
        {
            //logic check to see where camera should be
            Debug.Log("Camera should be out of ADS state");
            //move camera to the ADS 
            transform.Translate(0.0f, 1.5f, -7.5f);
            //we now need to change the cameras state to ADS
            state = State.Walking;
        }
    }
    #endregion

}