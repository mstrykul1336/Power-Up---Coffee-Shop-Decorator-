using UnityEngine;
using UnityEngine.SceneManagement;

public class kiosk : MonoBehaviour
{
    public void StartSceneKiosk()
    {
        SceneManager.LoadScene(sceneBuildIndex:1);
    }
}
