using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class DataManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static DataManager Instance;

    private int shotBullet;
    public int totalShotBullet;
    private int enemyKilled;
    public int totalEnemyKilled;
    public GameObject inGameScreen, pauseScreen;


    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public int ShotBullet
    {
        get
        {
            return shotBullet;
        }
        set 
        {
            shotBullet = value;
            GameObject.Find("ShotBulletText").GetComponent<Text>().text = "Shot Bullet :" + shotBullet.ToString();

        }
    }

    // EnemyKilled için property
    public int EnemyKilled
    {
        get
        {
            return enemyKilled;
        }
        set
        {
            enemyKilled = value;
            GameObject.Find("EnemyKilledText").GetComponent<Text>().text = "Enemy Killed :" + enemyKilled.ToString();
            WinProcess();

        }
    }

   

    public void WinProcess()
    {
        if(enemyKilled >=2)
        {
            print("Win");

            GameObject.Find("WinText").GetComponent<Text>().text = "   Win!!\r\nKAzandýnýz!! :";

            



            Time.timeScale = 1;
            SceneManager.LoadScene(0);

        }
       
    }

    public void LoseProcess()
    {
        if (enemyKilled >= 2)
        {
            print("Lose");
        }
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

}

