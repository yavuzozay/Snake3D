using System;
using UnityEngine;

public static class EventManager 
{

    public static event Action onGameOver;
    public static void Fire_onGameOver() { onGameOver?.Invoke(); }
    public static event Action<int> onScoreChanged;
    public static void Fire_onScoreChanged(int score) { onScoreChanged?.Invoke(score); }
}
