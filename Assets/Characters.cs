using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Characters : MonoBehaviour
{
    public abstract CharResultQuestion AskQuestion(GameState gamestate);
    
}

