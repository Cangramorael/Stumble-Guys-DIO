using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Singleton
    public static GameManager Instance {get; private set;}

    // API
    public bool isGameOver {get; private set;}
    [SerializeField] private AudioSource musicGame;
    [SerializeField] private AudioSource gameOverSfx;

    void Awake() {
        if(Instance != null && Instance != this) {
            Destroy(this);
        } else {
            Instance = this;
        }
    }

    public void EndGame() {
        if(isGameOver) return;

        // Set flag
        isGameOver = true;

        // Stop music
        musicGame.Stop();

        //Play SFX
        gameOverSfx.Play();
    }

}
