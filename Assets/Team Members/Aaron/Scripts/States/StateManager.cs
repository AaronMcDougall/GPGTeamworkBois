using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aaron
{
    public class StateManager : MonoBehaviour
    {
        public StateBase currentState;

        private void Update()
        {
            //run the stateChange
        }

        public void changeState(StateBase newState)
        {
            if(currentState != null)
            {
                Debug.Log("current state is " + currentState);
                currentState.Exit();

                newState.Enter();
                currentState = newState;
                Debug.Log("New Current state is " + currentState);
            }
        }
    }
}

