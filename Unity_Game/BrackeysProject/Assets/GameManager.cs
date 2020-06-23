using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool hasGameEnded = false;
    
    public float restartDelay = 1f;

    public void GameOver(){
       if(hasGameEnded == false)
       {
        hasGameEnded = true;
        Debug.Log("Game Over");
        Invoke("RestartGame", restartDelay);
       }
        
    }

    void RestartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
