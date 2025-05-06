using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySwitchBehaviour : MonoBehaviour
{
    public enum STATE
    { 
        IDLE,
        AGGROED,
        ATTACKING,
        DEFEATED

    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public STATE state = STATE.DEFEATED;
    // Update is called once per frame
    void Update()
    {
        switch (state) 
        {
            case STATE.IDLE: Debug.Log("il nemico è fermo");
                break;
            case STATE.AGGROED: Debug.Log("il nemico insegue il giocatore");
                break;
            case STATE.ATTACKING: Debug.Log("il nemico sta attaccando il giocatore");
                break;
            case STATE.DEFEATED: Debug.Log("il nemico è sconfitto");
                break;
        }
    }
}
