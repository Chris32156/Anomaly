using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    Game game;

    private void Start()
    {
        game = FindObjectOfType<Game>();

    }

    public void Button0()
    {
        game.CheckAnswer(0);
    }

    public void Button1()
    {
        game.CheckAnswer(1);
    }

    public void Button2()
    {
        game.CheckAnswer(2);
    }

    public void Button3()
    {
        game.CheckAnswer(3);
    }

    public void Button4()
    {
        game.CheckAnswer(4);
    }
}
