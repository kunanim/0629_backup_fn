using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string sceneName;

    public void ChangeToScene()
    {
        if (string.IsNullOrEmpty(sceneName))
        {
            Debug.LogWarning("SceneChanger: sceneName is empty!");
            return;
        }
        SceneManager.LoadScene(sceneName);
    }
}
