using Unity.VectorGraphics;
using UnityEditor.SceneManagement;
using UnityEngine;
public class SceneChange : MonoBehaviour
{
    public string SceneName;

    private void OnTriggerEnter(Collider other)
    {
        EditorSceneManager.LoadScene(SceneName);

    }

}
