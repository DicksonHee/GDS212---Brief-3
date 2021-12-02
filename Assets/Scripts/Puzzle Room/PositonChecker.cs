using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositonChecker : MonoBehaviour
{
    public ObjectSpin objectOne;
    public ObjectSpin objectTwo;
    public ObjectSpin objectThree;
    public ObjectSpin objectFour;
    public bool gateOpened;
    public Animator gateAnimator;
    
    void Update()
    {
        if(objectOne.correctPosition == true && objectTwo.correctPosition == true 
            && objectThree.correctPosition == true && objectFour.correctPosition == true)
        {
			gateAnimator.Play("OpenGateAnim");
            Debug.Log("Gate Opened");
            gateOpened = true;
        }
    }
}
