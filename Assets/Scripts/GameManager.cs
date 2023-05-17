using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject cactus;
    public GameObject cactusSpawnPosition;
    public GameObject GameOverScene;
    public float spawnTime;
    float timer;
    void Start()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnTime)
        {
            Instantiate(cactus,cactusSpawnPosition.transform);
            timer = 0;
        }
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        GameOverScene.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene("Stage");
    }
}
