using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : Characters
{    public override CharResultQuestion AskQuestion(GameState gamestate)
    {
        return new CharResultQuestion("Кудесник спрашивает: ");
    }
}
