using System;
using UnityEngine;

public static class EventManager 
{

    public static event Action onGameOver;
    public static void Fire_onGameOver() { onGameOver?.Invoke(); }
}
