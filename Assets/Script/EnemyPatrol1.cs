using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyPatrol1 : MonoBehaviour
{
    public float enemySpeed = 4;
    public string sceneName;

    void Update()
    {
        transform.Translate(Vector3.up * enemySpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
