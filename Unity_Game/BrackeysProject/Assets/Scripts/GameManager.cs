using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool hasGameEnded = false;
    
    public float restartDelay = 1f;

    public GameObject completeLevelUI;

    public void GameOver(){
       if(hasGameEnded == false)
       {
        hasGameEnded = true;
        Debug.Log("Game Over");
        Invoke("RestartGame", restartDelay);
       }
        
    }
    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }
    void RestartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
