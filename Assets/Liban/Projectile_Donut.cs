using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile_Donut : MonoBehaviour
{

    public Rigidbody bulletPrefabs;

    public GameObject cursor;

    public LayerMask Layer;

    private Camera Camyeahyeah;

    public Transform shootingpoint;

    // Start is called before the first frame update
    void Start()
    {

        Camyeahyeah = Camera.main;

    }

    // Update is called once per frame
    void Update()
    {

        Launch();

    }



    void Launch()

    {

        Ray camRay = Camyeahyeah.ScreenPointToRay(Input.mousePosition);
        RaycastHit Hit;



        if (Physics.Raycast(camRay, out Hit, 100f, Layer))


        {

            cursor.SetActive(true);
            cursor.transform.position = Hit.point + Vector3.up * 1.1f;


            Vector3 Vo = CalculateVelocity(Hit.point, shootingpoint.position, 1f);


            transform.rotation = Quaternion.LookRotation(Vo);



           

            if (Input.GetMouseButton(0))

            {


                Rigidbody obj = Instantiate(bulletPrefabs, shootingpoint.position, Quaternion.identity);

                obj.velocity = Vo;
            }

        }

        else

        {

            cursor.SetActive(false);

        }



    }








    Vector3 CalculateVelocity(Vector3 target, Vector3 origin, float time)

    {

        Vector3 distance = target - origin;
        Vector3 distanceXZ = distance;
        distanceXZ.y = 0f;



        float Sy = distance.y;
        float Sxz = distanceXZ.magnitude;

        float Vxz = Sxz / time;
        float Vy = Sy / time + 0.5f * Mathf.Abs(Physics.gravity.y) * time;

        Vector3 result = distanceXZ.normalized;
        result *= Vxz;
        result.y = Vy;


       return result;





    }


}