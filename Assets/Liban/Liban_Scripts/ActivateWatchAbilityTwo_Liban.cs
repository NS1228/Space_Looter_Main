using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateWatchAbilityTwo_Liban : MonoBehaviour

{




    public Transform TheeeePlayer;

    public Material Ghoooooost;

    public Material Normallll;

    public GameObject TheWatchYEAHYEAH;

    public Transform YoFace;

    public float smoothhhh;





    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {




        if (Input.GetMouseButtonDown(1))


        {

            Nil_FOVdetection.phantasm = true;
            StartCoroutine(ActivateTheGHOSTSSS());



        }

    }




    IEnumerator ActivateTheGHOSTSSS()


    {


        TheWatchYEAHYEAH.GetComponent<MeshRenderer>().enabled = false;

        TheWatchYEAHYEAH.GetComponent<BoxCollider>().enabled = false;



         TheeeePlayer.GetComponent<MeshRenderer>().material = Ghoooooost;


          YoFace.GetComponent<MeshRenderer>().material = Ghoooooost;




       






        ActivateWatchAbilityTwo_Liban GHTY = GameObject.Find("Activate second watch ability").GetComponent<ActivateWatchAbilityTwo_Liban>();

        GHTY.enabled = false;








        //Stun_Light_Liban STYP123 = GameObject.FindWithTag("FlashLight").GetComponent<Stun_Light_Liban>();

        //STYP123.enabled = false;






        //ActivateWatchAbility TYUI = GameObject.Find("Activate the watch ability").GetComponent<ActivateWatchAbility>();

        //TYUI.enabled = false;

     








        yield return new WaitForSeconds(5.0f);









        TheeeePlayer.GetComponent<MeshRenderer>().material = Normallll;

        YoFace.GetComponent<MeshRenderer>().material = Normallll;





        Nil_FOVdetection.phantasm = false;





        Stun_Light_Liban STYUI14 = GameObject.FindWithTag("FlashLight").GetComponent<Stun_Light_Liban>();

        STYUI14.enabled = true;









        yield return new WaitForSeconds(6.0f);











        TheWatchYEAHYEAH.GetComponent<MeshRenderer>().enabled = true;


        TheWatchYEAHYEAH.GetComponent<BoxCollider>().enabled = true;





       // ActivateWatchAbilityTwo_Liban AVWA2 = GameObject.Find("Activate second watch ability").GetComponent<ActivateWatchAbilityTwo_Liban>();

       // AVWA2.enabled = true;





        ActivateWatchAbility POIU = GameObject.Find("Activate the watch ability").GetComponent<ActivateWatchAbility>();

        POIU.enabled = true;


        GetComponent<ActivateWatchAbilityTwo_Liban>().enabled = true;



    }


}



