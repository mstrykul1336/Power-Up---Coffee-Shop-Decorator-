using UnityEngine;
using UnityEngine.SceneManagement;
public class gamemanager : MonoBehaviour
{
    public float restartDelay =1f;
    public void completeLevel() {   
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
}
