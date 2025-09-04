using UnityEngine;
using UnityEngine.SceneManagement;

public class Recenhecer : MonoBehaviour
{
    string scene;
    private void Awake()
    {
#if UNITY_STANDALONE_WIN
        scene = "InGameWin";
#elif UNITY_ANDROID
        scene = "InGame";
#endif
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void InGameScene()
    {
        SceneManager.LoadScene(scene);
    }
}
