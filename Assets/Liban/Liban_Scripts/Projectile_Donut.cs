using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile_Donut : MonoBehaviour
{

    public Rigidbody bulletPrefabs;

    public GameObject cursor;

    public LayerMask Layer;

    public Camera Camyeahyeah;      // if doesn't work, then revert back to private

    public Transform shootingpoint;

    public LineRenderer TheLine;

    public int linesegment = 12;

    private float speed = 50.3f;

    // Start is called before the first frame update
    void Start()
    {

              //if doesn't work, then uncomment this line


        TheLine.positionCount = linesegment;

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
            cursor.transform.position = Hit.point + Vector3.up * 1.5f;


            Vector3 Vo = CalculateVelocity(Hit.point, shootingpoint.position, 2.3f);


            Visualize(Vo);


         //   transform.rotation = Quaternion.LookRotation(Vo);



           

            if (Input.GetMouseButtonUp(0))

            {


                Rigidbody obj = Instantiate(bulletPrefabs, shootingpoint.position, shootingpoint.rotation);

                obj.velocity = Vo;


            }

        }

    }




    void Visualize (Vector3 vo)



    {

        for (int i = 0; i < linesegment; i++)

        {

            Vector3 pos = Calculatepositionintime(vo, i / (float)linesegment);


            TheLine.SetPosition(i, pos);



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






    Vector3 Calculatepositionintime(Vector3 vo, float time)


    {


        Vector3 VXZ = vo;

        VXZ.y = 0f;



        Vector3 result = shootingpoint.position + vo * time;

        float sY = (-0.5f * Mathf.Abs(Physics.gravity.y) * (time * time)) + (vo.y * time) + shootingpoint.position.y;

        result.y = sY;


        return result;

    }


}