using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    [TextArea(14,10)] [SerializeField] string storyText; // Text area 1st number shows min size in the inspector or our field and 2nd number of lines after which it will add a scroll bar
    [SerializeField] private State[] nextStates;

    public string GetStateStory()
    {
        return storyText;
    }



    public State[] GetNextState()
    {
        return nextStates;
        //return nextStates[(currStateIndex + 1) % nextStates.Length];
    }
}
