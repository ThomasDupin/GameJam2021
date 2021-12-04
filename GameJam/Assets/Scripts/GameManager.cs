using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false;

    public float restartDelay = 1f;

    public string LevelName;


    public void EndGame()
    {

        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            
            Invoke("Restart", restartDelay);
            
        }

    }

    void Restart()
    {
        SceneManager.LoadScene(LevelName);
    }
}
