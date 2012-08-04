//---------------------------------------------
// Dan Welsh - 2012
// Danveria Acrade Control scrpts
// Shooter - Camera ver 0.01
//---------------------------------------------


using UnityEngine;
using System.Collections;

public class S_16012012_ShooterControls_Camera_KBM : MonoBehaviour
{

    #region DataStore



    #endregion


    #region States
    enum State
    {
        Adventure,
        Aiming,
        AimDownScope
    }

    private State state = State.Adventure;

    #endregion


    #region Functions
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //We need to set a default camera position
        //we will need to talk to the camera position and set it to this deafult
        //position

        //here we will set camera controls that will be used for the demo 
        //these may well need to made into on/off style switches
        //As this is a 3 way switch we will need to check what state the camera is in
        //and if it is already in the Aiming State then we will need move the camera to 
        //its default psoition/state


        //move camera to and back from aiming position
        if (Input.GetKeyDown("mouse 1"))
        {
            //logic check to see where camera should be
            Debug.Log("Camera should be in Aiming state");
            
            //move camera Aiming location
            transform.Translate(1.75f, -0.7f, 0.4f);
            
            //we now need to change the cameras state to Aiming
            state = State.Aiming;
        }

        if (Input.GetKeyUp("mouse 1"))
        {
            //logic check to see where camera should be
            Debug.Log("Camera should be out of Aiming state");
            
            //move camera Aiming location
            transform.Translate(-1.75f, 0.5f, -4.5f);
            
            //we now need to change the cameras state to Aiming
            state = State.Adventure;
        }

        //Sprint     
        if (Input.GetKeyDown("left shift"))
        {
            //logic check to see where camera should be
            Debug.Log("Camera should be in ADS state");
            
            //move camera to the ADS 
            transform.Translate(0.0f, -0.7f, 7.5f);
            
            //we now need to change the cameras state to ADS
            state = State.AimDownScope;
        }

        if (Input.GetKeyUp("left shift"))
        {
            //logic check to see where camera should be
            Debug.Log("Camera should be out of ADS state");
            //move camera to the ADS 
            transform.Translate(0.0f, 1.5f, -7.5f);
            //we now need to change the cameras state to ADS
            state = State.AimDownScope;
        }
    }
    #endregion

}