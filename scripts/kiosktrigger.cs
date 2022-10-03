using UnityEngine;
using UnityEngine.SceneManagement;

public class kiosktrigger : MonoBehaviour
{
    public gamemanager gameManager;
    void OnTriggerEnter()
    {
        SceneManager.LoadScene(sceneBuildIndex:1);
    }
}