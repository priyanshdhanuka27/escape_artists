 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine : StateMachine
{
    [field: SerializeField] public InputReader inputReader {get; private set; }
    // Start is called before the first frame update
    void Start()
    {
        SwitchState(new PlayerTestState(this));
    }
}
