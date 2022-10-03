using UnityEngine;
using UnityEngine.SceneManagement;

public class end: MonoBehaviour
{
    public void StartSceneEnd()
    {
        SceneManager.LoadScene(sceneBuildIndex:2);
    }
}
