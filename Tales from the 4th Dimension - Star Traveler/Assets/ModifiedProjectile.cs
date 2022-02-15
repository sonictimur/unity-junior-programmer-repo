using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModifiedProjectile : Projectile
{
    public Color newColour;

    // Polymorphism
    public override void ShootProjectileWithDifferentColour()
    {
        base.ShootProjectileWithDifferentColour();

        color = newColour;

        Instantiate(projectilePrefab);
    }
}
