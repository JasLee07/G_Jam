using UnityEngine;
using UnityEngine.SceneManagement;

public class switch_to_scene : MonoBehaviour
{
    [SerializeField] private string sceneName;

    private void OnMouseDown()
    {
        if(string.IsNullOrWhiteSpace(sceneName))
        {
            Debug.LogError("Scene name is not set. Please assign a scene name in the inspector.");
            return;
        }
        SceneManager.LoadScene(sceneName);
    }
}
