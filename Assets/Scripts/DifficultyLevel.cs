using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DifficultyLevel 
{
    // Start is called before the first frame update

    private static float secondsToMaxDifficulty = 60;

    public static float GetDifficultyPercent()
    {
        return 1;
            
        return Mathf.Clamp01(Time.time / secondsToMaxDifficulty);
    }
    
}
