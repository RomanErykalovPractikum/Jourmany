using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Detective : Characters
{
    public override CharResultQuestion AskQuestion(GameState gamestate)
    {
        return new CharResultQuestion("Кудесник спрашивает: ");
    }
}
