using UnityEngine;
using UnityEngine.SceneManagement;
public class gamemanager : MonoBehaviour
{
    bool gamehasended = false;
    public float restartdealy = 1f;
    public void Gameover()
    {
        if(gamehasended == false)
        {
         gamehasended = true;
         Debug.Log("GameOver");
         Invoke("restart",restartdealy);
        }
    }

    void restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
