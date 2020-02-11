using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile_Donut : MonoBehaviour
{

    public Transform TheTarget;

    public float FiringAngle = 45.0f;

    public float Gravity = 9.8f;

    public Transform Projectile;

    private Transform myTransform;



    // Start is called before the first frame update
    void awake()
    {

        myTransform = transform;
        
    }

    // Update is called once per frame
    void Update()
    {

        Projectile.position = myTransform.position + new Vector3(0, 0.0f, 0);

        float target_distance = Vector3.Distance(Projectile.position, TheTarget.position);

        float projectile_velocity = target_distance / (Mathf.Sin(2 * FiringAngle * Mathf.Deg2Rad) / Gravity);


        float Vx = Mathf.Sqrt(projectile_velocity) * Mathf.Cos(FiringAngle * Mathf.Deg2Rad);

        float Vy = Mathf.Sqrt(projectile_velocity) * Mathf.Sin(FiringAngle * Mathf.Deg2Rad);

        float FlightDuration = target_distance / Vx;

        Projectile.rotation = Quaternion.LookRotation(TheTarget.position - Projectile.position);





    }
}
