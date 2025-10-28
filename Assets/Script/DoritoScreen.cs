using UnityEngine;
using UnityEngine.SceneManagement;

public class DoritoScreen : MonoBehaviour
{
    public string levelToLoad;

    public void Restart()
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
