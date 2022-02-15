using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ProjectileForward : MonoBehaviour
{
    public GameObject enemy;
    public float speed;
    public int damage;

    // Start is called before the first frame update
    void Start()
    {
        transform.DOMove(enemy.transform.position, speed).OnComplete(Hit);
    }

    public void Hit()
    {
        // Minus enemies damage here

        Destroy(gameObject);
    }
}
