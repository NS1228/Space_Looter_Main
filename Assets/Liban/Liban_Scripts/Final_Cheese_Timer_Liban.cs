using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final_Cheese_Timer_Liban : MonoBehaviour
{


    public float GunkyTimer = 16f;

    public GameObject TheTooooorch;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        GunkyTimer -= Time.deltaTime;


        int secondsy = (int)(GunkyTimer % 60);




       



        if (GunkyTimer <= 16)


        {



         //   GetComponent<Cheese_Gunk_Liban>().enabled = true;

          //  GetComponent<Cheese_ShrinkingPOWERUP>().enabled = true;




           


        }











        if(GunkyTimer <= 8)


        {




            GetComponent<Cheese_Gunk_Liban>().enabled = false;



            GetComponent<Cheese_ShrinkingPOWERUP>().enabled = false;


            GetComponent<Activate_CheeseAbilities_Liban>().enabled = false;


            INstant_Liban IL1 = GameObject.FindWithTag("Gunk Loc").GetComponent<INstant_Liban>();

            IL1.enabled = false;


            TheTooooorch.SetActive(true);



            Cheese_ShrinkingPOWERUP FINALSHRINK = GameObject.FindWithTag("CheesePowerUp").GetComponent<Cheese_ShrinkingPOWERUP>();

            FINALSHRINK.CTrigger.transform.localScale = new Vector3(1f, 1f, 1f);

            FINALSHRINK.CVisual.transform.localScale = new Vector3(1f, 1f, 1f);

            FINALSHRINK.RTrigger.transform.localScale = new Vector3(1f, 1f, 1f);

            FINALSHRINK.RVisual.transform.localScale = new Vector3(1f, 1f, 1f);

            FINALSHRINK.WTrigger.transform.localScale = new Vector3(1f, 1f, 1f);

            FINALSHRINK.WVisual.transform.localScale = new Vector3(1f, 1f, 1f);

            FINALSHRINK.ThePlayer.transform.localScale = new Vector3(1f, 1f, 1f); 


            


        }







        if(GunkyTimer <= 1)



        {



            GetComponent<Activate_CheeseAbilities_Liban>().enabled = true;

            GunkyTimer = 16.0f;



            GetComponent<Final_Cheese_Timer_Liban>().enabled = false;



        }








    }
}
