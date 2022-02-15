using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Color color;
    public Vector3 projectileSize;
    public float timeToGetToEnemy;
    public int damage;

    // Polymorphism
    public virtual void ShootProjectileWithDifferentColour()
    {
        color = Color.red;
    }
}
