using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationHelper : MonoBehaviour
{

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
  
        //Прыжок
        if (Input.GetButtonDown("Jump") && !Input.GetButtonUp("Jump"))
        {
            GetComponent<Animator>().SetBool("Jump", true);

        }
        else
        {
            GetComponent<Animator>().SetBool("Jump", false);
        }

        //Движение вперед
        if (Input.GetButton("Vertical") && Input.GetAxis("Vertical") > 0 && !Input.GetButtonUp("Vertical"))
        {
                    GetComponent<Animator>().SetBool("MoveBackwardSwitcher", false);
       
                    GetComponent<Animator>().SetBool("MoveForwardSwitcher", true);
     

        }
        //Движение налево
        if (Input.GetButton("Horizontal") && Input.GetAxis("Horizontal") < 0 && !Input.GetButtonUp("Horizontal"))
        {

            GetComponent<Animator>().SetBool("MoveLeftSwitcher", true);

        }
        else
        {
            GetComponent<Animator>().SetBool("MoveLeftSwitcher", false);
        }
        //Движение направо
        if (Input.GetButton("Horizontal") && Input.GetAxis("Horizontal") > 0 && !Input.GetButtonUp("Horizontal"))
        {
            GetComponent<Animator>().SetBool("MoveRightSwitcher", true);

        }
        else
        {
            GetComponent<Animator>().SetBool("MoveRightSwitcher", false);
        }
        //Движение назад 
        if (Input.GetButton("Vertical") && Input.GetAxis("Vertical") < 0 && !Input.GetButtonUp("Vertical"))
        {
            GetComponent<Animator>().SetBool("MoveForwardSwitcher", false);
            GetComponent<Animator>().SetBool("MoveBackwardSwitcher", true);
            
        }
        if (Input.GetButtonUp("Vertical") && !Input.GetButton("Vertical"))
        {
            GetComponent<Animator>().SetBool("MoveForwardSwitcher", false);
            GetComponent<Animator>().SetBool("MoveBackwardSwitcher", false);
           
        }
 
 
    }
}
