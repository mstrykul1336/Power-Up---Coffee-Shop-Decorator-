using UnityEngine;
using UnityEngine.SceneManagement;

public class orderstart : MonoBehaviour
{
    public void StartOrderScene()
    {
        SceneManager.LoadScene(sceneBuildIndex:1);
    }
}
