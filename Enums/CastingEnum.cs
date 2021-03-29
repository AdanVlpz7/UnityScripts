using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CastingEnum : MonoBehaviour
{
    public enum Difficulty
    {
        easy,
        normal,
        difficult
    }

    public Difficulty sceneDifficulty;

    private void Start()
    {
        SceneManager.LoadScene((int)sceneDifficulty);
    }
}
