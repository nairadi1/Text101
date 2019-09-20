using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    // Instance/ member variable
    [SerializeField] private Text storyTextComponent;
    [SerializeField] private State startingState;

    State state;

    

    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        storyTextComponent.text = state.GetStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        var nextStates = state.GetNextState();

        for(int i = 0; i < nextStates.Length; i++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + i))
            {
                state = nextStates[i];
            }
        }

        //if (Input.GetKeyDown(KeyCode.Alpha1))
        //{
        //    state = nextStates[0];
        //} else if (Input.GetKeyDown(KeyCode.Alpha2))
        //{
        //    state = nextStates[1];
        //} else if (Input.GetKeyDown(KeyCode.Alpha3))
        //{
        //    state = nextStates[2];
        //}
        storyTextComponent.text = state.GetStateStory();
    }
}
