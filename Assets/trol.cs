using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trol : Characters
{
    public override CharResultQuestion AskQuestion(GameState gamestate)
    {
        return new CharResultQuestion ("Толль спрашивает: ");
    }
}
