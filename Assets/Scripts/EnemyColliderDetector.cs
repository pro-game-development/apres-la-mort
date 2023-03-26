using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyColliderDetector : MonoBehaviour
{
    public string enemyTag = "Enemy";
    public float minX = -10f;
    public float maxX = 10f;
    public float minZ = -10f;
    public float maxZ = 10f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(enemyTag))
        {
            Vector3 newPosition = new Vector3(Random.Range(minX, maxX), 0, Random.Range(minZ, maxZ));
            other.transform.position = newPosition;
        }
    }
}
