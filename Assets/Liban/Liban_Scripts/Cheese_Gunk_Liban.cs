using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheese_Gunk_Liban : MonoBehaviour
{

    public GameObject Gunk;

    public Transform GunkSpot;

    


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.H))


        {



            StartCoroutine(TheCheeseGunk());


           

            

            }



        }
    





        IEnumerator TheCheeseGunk()



        {






         
           INstant_Liban I_L = GameObject.FindWithTag("Gunk Loc").GetComponent<INstant_Liban>();


           I_L.enabled = true;

             

















            ActivateWatchAbilityTwo_Liban AZX = GameObject.Find("Activate second watch ability").GetComponent<ActivateWatchAbilityTwo_Liban>();

            AZX.enabled = false;




















            yield return new WaitForSeconds(4.5f);



























            ActivateWatchAbilityTwo_Liban AZX2 = GameObject.Find("Activate second watch ability").GetComponent<ActivateWatchAbilityTwo_Liban>();

            AZX2.enabled = true;

















            INstant_Liban _IL2 = GameObject.FindWithTag("Gunk Loc").GetComponent<INstant_Liban>();

            _IL2.enabled = false; 






        }




    }
