using UnityEngine;
using UnityEngine.SceneManagement;

public class Load_Specific_Scene : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            SceneManager.LoadScene("Level01");
        }
    }
}
