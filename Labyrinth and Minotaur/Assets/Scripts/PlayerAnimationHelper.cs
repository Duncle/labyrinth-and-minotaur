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
        //������
        if (Input.GetButtonDown("Jump") && controller.isGrounded)
        {
            GetComponent<Animator>().SetBool("Jump", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("Jump", false);
        }
      

        //������
        //������
        if (Input.GetButton("Vertical") && Input.GetAxis("Vertical") > 0 && !Input.GetButton("Horizontal") && !Input.GetKey(KeyCode.LeftShift))
        {
            GetComponent<Animator>().SetBool("ForwardWalk", true);

        }
        else
        {
            GetComponent<Animator>().SetBool("ForwardWalk", false);
        }
        // �����
        if (Input.GetButton("Vertical") && Input.GetAxis("Vertical") < 0 && !Input.GetButton("Horizontal") && !Input.GetKey(KeyCode.LeftShift))
        {

            GetComponent<Animator>().SetBool("BackwardWalk", true);

        }
        else
        {
            GetComponent<Animator>().SetBool("BackwardWalk", false);
        }

        // ������
        if (Input.GetButton("Horizontal") && Input.GetAxis("Horizontal") < 0 && !Input.GetButton("Vertical") && !Input.GetKey(KeyCode.LeftShift))
        {

            GetComponent<Animator>().SetBool("LeftWalk", true);

        }
        else
        {
            GetComponent<Animator>().SetBool("LeftWalk", false);
        }
        //�������
        if (Input.GetButton("Horizontal") && Input.GetAxis("Horizontal") > 0 && !Input.GetButton("Vertical") && !Input.GetKey(KeyCode.LeftShift))
        {
            GetComponent<Animator>().SetBool("RightWalk", true);

        }
        else
        {
            GetComponent<Animator>().SetBool("RightWalk", false);
        }

        //������ �������
        if (Input.GetButton("Vertical") && Input.GetAxis("Vertical") > 0 && Input.GetButton("Horizontal") && Input.GetAxis("Horizontal") > 0 && !Input.GetKey(KeyCode.LeftShift))
        {
            GetComponent<Animator>().SetBool("ForwardRightWalk", true);

        }
        else
        {
            GetComponent<Animator>().SetBool("ForwardRightWalk", false);
        }
        //������ ������
        if (Input.GetButton("Vertical") && Input.GetAxis("Vertical") > 0 && Input.GetButton("Horizontal") && Input.GetAxis("Horizontal") < 0 && !Input.GetKey(KeyCode.LeftShift))
        {
            GetComponent<Animator>().SetBool("ForwardLeftWalk", true);

        }
        else
        {
            GetComponent<Animator>().SetBool("ForwardLeftWalk", false);
        }

        //����� �������
        if (Input.GetButton("Vertical") && Input.GetAxis("Vertical") < 0 && Input.GetButton("Horizontal") && Input.GetAxis("Horizontal") > 0 && !Input.GetKey(KeyCode.LeftShift))
        {
            GetComponent<Animator>().SetBool("BackwardRightWalk", true);

        }
        else
        {
            GetComponent<Animator>().SetBool("BackwardRightWalk", false);
        }
        //����� ������
        if (Input.GetButton("Vertical") && Input.GetAxis("Vertical") < 0 && Input.GetButton("Horizontal") && Input.GetAxis("Horizontal") < 0 && !Input.GetKey(KeyCode.LeftShift))
        {
            GetComponent<Animator>().SetBool("BackwardLeftWalk", true);

        }
        else
        {
            GetComponent<Animator>().SetBool("BackwardLeftWalk", false);
        }

        //<���
        //������
        if (Input.GetButton("Vertical") && Input.GetAxis("Vertical") > 0 && !Input.GetButton("Horizontal") && Input.GetKey(KeyCode.LeftShift))
        {
            GetComponent<Animator>().SetBool("ForwardRun", true);

        }
        else
        {
            GetComponent<Animator>().SetBool("ForwardRun", false);
        }
        // �����
        if (Input.GetButton("Vertical") && Input.GetAxis("Vertical") < 0 && !Input.GetButton("Horizontal") && Input.GetKey(KeyCode.LeftShift))
        {

            GetComponent<Animator>().SetBool("BackwardRun", true);

        }
        else
        {
            GetComponent<Animator>().SetBool("BackwardRun", false);
        }

        // ������
        if (Input.GetButton("Horizontal") && Input.GetAxis("Horizontal") < 0 && !Input.GetButton("Vertical") && Input.GetKey(KeyCode.LeftShift))
        {

            GetComponent<Animator>().SetBool("LeftRun", true);

        }
        else
        {
            GetComponent<Animator>().SetBool("LeftRun", false);
        }
        //�������
        if (Input.GetButton("Horizontal") && Input.GetAxis("Horizontal") > 0 && !Input.GetButton("Vertical") && Input.GetKey(KeyCode.LeftShift))
        {
            GetComponent<Animator>().SetBool("RightRun", true);

        }
        else
        {
            GetComponent<Animator>().SetBool("RightRun", false);
        }

        //������ �������
        if (Input.GetButton("Vertical") && Input.GetAxis("Vertical") > 0 && Input.GetButton("Horizontal") && Input.GetAxis("Horizontal") > 0 && Input.GetKey(KeyCode.LeftShift))
        {
            GetComponent<Animator>().SetBool("ForwardRightRun", true);

        }
        else
        {
            GetComponent<Animator>().SetBool("ForwardRightRun", false);
        }
        //������ ������
        if (Input.GetButton("Vertical") && Input.GetAxis("Vertical") > 0 && Input.GetButton("Horizontal") && Input.GetAxis("Horizontal") < 0 && Input.GetKey(KeyCode.LeftShift))
        {
            GetComponent<Animator>().SetBool("ForwardLeftRun", true);

        }
        else
        {
            GetComponent<Animator>().SetBool("ForwardLeftRun", false);
        }

        //����� �������
        if (Input.GetButton("Vertical") && Input.GetAxis("Vertical") < 0 && Input.GetButton("Horizontal") && Input.GetAxis("Horizontal") > 0 && Input.GetKey(KeyCode.LeftShift))
        {
            GetComponent<Animator>().SetBool("BackwardRightRun", true);

        }
        else
        {
            GetComponent<Animator>().SetBool("BackwardRightRun", false);
        }
        //����� ������
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
