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
        CharacterController controller = GetComponent<CharacterController>();
        //Прыжок
        if (Input.GetButtonDown("Jump") && controller.isGrounded)
        {
            GetComponent<Animator>().SetBool("Jump", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("Jump", false);
        }
      

        //Ходьба
        //вперед
        if (Input.GetButton("Vertical") && Input.GetAxis("Vertical") > 0 && !Input.GetButton("Horizontal") && !Input.GetKey(KeyCode.LeftShift))
        {
            GetComponent<Animator>().SetBool("ForwardWalk", true);

        }
        else
        {
            GetComponent<Animator>().SetBool("ForwardWalk", false);
        }
        // назад
        if (Input.GetButton("Vertical") && Input.GetAxis("Vertical") < 0 && !Input.GetButton("Horizontal") && !Input.GetKey(KeyCode.LeftShift))
        {

            GetComponent<Animator>().SetBool("BackwardWalk", true);

        }
        else
        {
            GetComponent<Animator>().SetBool("BackwardWalk", false);
        }

        // налево
        if (Input.GetButton("Horizontal") && Input.GetAxis("Horizontal") < 0 && !Input.GetButton("Vertical") && !Input.GetKey(KeyCode.LeftShift))
        {

            GetComponent<Animator>().SetBool("LeftWalk", true);

        }
        else
        {
            GetComponent<Animator>().SetBool("LeftWalk", false);
        }
        //направо
        if (Input.GetButton("Horizontal") && Input.GetAxis("Horizontal") > 0 && !Input.GetButton("Vertical") && !Input.GetKey(KeyCode.LeftShift))
        {
            GetComponent<Animator>().SetBool("RightWalk", true);

        }
        else
        {
            GetComponent<Animator>().SetBool("RightWalk", false);
        }

        //вперед направо
        if (Input.GetButton("Vertical") && Input.GetAxis("Vertical") > 0 && Input.GetButton("Horizontal") && Input.GetAxis("Horizontal") > 0 && !Input.GetKey(KeyCode.LeftShift))
        {
            GetComponent<Animator>().SetBool("ForwardRightWalk", true);

        }
        else
        {
            GetComponent<Animator>().SetBool("ForwardRightWalk", false);
        }
        //вперед налево
        if (Input.GetButton("Vertical") && Input.GetAxis("Vertical") > 0 && Input.GetButton("Horizontal") && Input.GetAxis("Horizontal") < 0 && !Input.GetKey(KeyCode.LeftShift))
        {
            GetComponent<Animator>().SetBool("ForwardLeftWalk", true);

        }
        else
        {
            GetComponent<Animator>().SetBool("ForwardLeftWalk", false);
        }

        //назад направо
        if (Input.GetButton("Vertical") && Input.GetAxis("Vertical") < 0 && Input.GetButton("Horizontal") && Input.GetAxis("Horizontal") > 0 && !Input.GetKey(KeyCode.LeftShift))
        {
            GetComponent<Animator>().SetBool("BackwardRightWalk", true);

        }
        else
        {
            GetComponent<Animator>().SetBool("BackwardRightWalk", false);
        }
        //назад налево
        if (Input.GetButton("Vertical") && Input.GetAxis("Vertical") < 0 && Input.GetButton("Horizontal") && Input.GetAxis("Horizontal") < 0 && !Input.GetKey(KeyCode.LeftShift))
        {
            GetComponent<Animator>().SetBool("BackwardLeftWalk", true);

        }
        else
        {
            GetComponent<Animator>().SetBool("BackwardLeftWalk", false);
        }

        //<Бег
        //вперед
        if (Input.GetButton("Vertical") && Input.GetAxis("Vertical") > 0 && !Input.GetButton("Horizontal") && Input.GetKey(KeyCode.LeftShift))
        {
            GetComponent<Animator>().SetBool("ForwardRun", true);

        }
        else
        {
            GetComponent<Animator>().SetBool("ForwardRun", false);
        }
        // назад
        if (Input.GetButton("Vertical") && Input.GetAxis("Vertical") < 0 && !Input.GetButton("Horizontal") && Input.GetKey(KeyCode.LeftShift))
        {

            GetComponent<Animator>().SetBool("BackwardRun", true);

        }
        else
        {
            GetComponent<Animator>().SetBool("BackwardRun", false);
        }

        // налево
        if (Input.GetButton("Horizontal") && Input.GetAxis("Horizontal") < 0 && !Input.GetButton("Vertical") && Input.GetKey(KeyCode.LeftShift))
        {

            GetComponent<Animator>().SetBool("LeftRun", true);

        }
        else
        {
            GetComponent<Animator>().SetBool("LeftRun", false);
        }
        //направо
        if (Input.GetButton("Horizontal") && Input.GetAxis("Horizontal") > 0 && !Input.GetButton("Vertical") && Input.GetKey(KeyCode.LeftShift))
        {
            GetComponent<Animator>().SetBool("RightRun", true);

        }
        else
        {
            GetComponent<Animator>().SetBool("RightRun", false);
        }

        //вперед направо
        if (Input.GetButton("Vertical") && Input.GetAxis("Vertical") > 0 && Input.GetButton("Horizontal") && Input.GetAxis("Horizontal") > 0 && Input.GetKey(KeyCode.LeftShift))
        {
            GetComponent<Animator>().SetBool("ForwardRightRun", true);

        }
        else
        {
            GetComponent<Animator>().SetBool("ForwardRightRun", false);
        }
        //вперед налево
        if (Input.GetButton("Vertical") && Input.GetAxis("Vertical") > 0 && Input.GetButton("Horizontal") && Input.GetAxis("Horizontal") < 0 && Input.GetKey(KeyCode.LeftShift))
        {
            GetComponent<Animator>().SetBool("ForwardLeftRun", true);

        }
        else
        {
            GetComponent<Animator>().SetBool("ForwardLeftRun", false);
        }

        //назад направо
        if (Input.GetButton("Vertical") && Input.GetAxis("Vertical") < 0 && Input.GetButton("Horizontal") && Input.GetAxis("Horizontal") > 0 && Input.GetKey(KeyCode.LeftShift))
        {
            GetComponent<Animator>().SetBool("BackwardRightRun", true);

        }
        else
        {
            GetComponent<Animator>().SetBool("BackwardRightRun", false);
        }
        //назад налево
        if (Input.GetButton("Vertical") && Input.GetAxis("Vertical") < 0 && Input.GetButton("Horizontal") && Input.GetAxis("Horizontal") < 0 && Input.GetKey(KeyCode.LeftShift))
        {
            GetComponent<Animator>().SetBool("BackwardLeftRun", true);

        }
        else
        {
            GetComponent<Animator>().SetBool("BackwardLeftRun", false);
        }
    }
}
