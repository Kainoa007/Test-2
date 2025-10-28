using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public float enemySpeed = 4;

    void Update()
    {
        transform.Translate(Vector3.right * enemySpeed * Time.deltaTime);
    }
}
