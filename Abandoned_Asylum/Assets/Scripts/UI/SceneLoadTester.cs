using UnityEngine;
public class SceneLoadTester : MonoBehaviour 
{ 
    private void Update()
    { 
        if (Input.GetKeyDown(KeyCode.Space))
        { 
            LoadingSceneManager.LoadScene("GameScene"); 
        }
    } 
}