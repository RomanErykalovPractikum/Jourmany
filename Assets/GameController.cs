using System;
using System.Collections;
using System.Collections.Generic;
//using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public enum KingState
{
    ok, war, sick, epidemy, madness, delight, revolt
}
public struct CharResultQuestion
{
    public string question;

    public CharResultQuestion (string question)
    {
        this.question = question;
    }
}

public struct GameState
{
    //resources
    public int food;
    public int money;
    public int techno;
    public int pollen;

    //relationships
    public int workers;
    public int pets;
    public int robots;
    public int gloves;
    public int scientists;
    public int galaxy;

    //state
    public KingState state;
}

public class GameController : MonoBehaviour
{
    private Characters[] characters = new Characters[3];
    private Characters character;
    private GameState gameState;
    private bool isAnswear;

    public Text mainText;

    void Start()
    {
        Init();
        Loop(); //Main Loop
    }

    void Init()
    {
        gameState.food = gameState.money = gameState.techno = gameState.pollen = 10;
        gameState.workers = gameState.pets = gameState.robots = gameState.gloves = gameState.scientists = gameState.galaxy = 5;
        gameState.state = KingState.ok;

        characters[0] = new Detective();
        characters[1] = new Wizard();
        characters[2] = new trol();
    }
    void Loop()
    {
        //Create new character
        NewCharacter();

        //Get Question
        CharResultQuestion charResultQuestion = character.AskQuestion(gameState);
        
        //Show question
        mainText.text = charResultQuestion.question;

        //YesNo
        
    }

    public void PLayerYesNo(bool playerYesNo)
    {
        isAnswear = playerYesNo;
        Debug.Log(isAnswear.ToString());
    }

    void NewCharacter()
    {
        int newComerId = UnityEngine.Random.Range(0, 3);
        character = characters[newComerId];
        Debug.Log("New character: " + newComerId);
    }

}
