using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) LoadNextScene();
    }

    [ContextMenu("ChangeScene")]
    public void LoadNextScene() 
    {
        Scene currentScene = SceneManager.GetActiveScene();
        int currentSceneIndex = currentScene.buildIndex;

        int maxSceneInBuild = SceneManager.sceneCountInBuildSettings;
        int NextSceneToLoad = (currentSceneIndex + 1)%maxSceneInBuild;

        SceneManager.LoadScene(NextSceneToLoad);
    }
}
