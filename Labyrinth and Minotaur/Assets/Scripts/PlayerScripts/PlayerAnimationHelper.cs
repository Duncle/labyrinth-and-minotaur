using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationHelper : MonoBehaviour
{
    private Animator playerAnimator;
    void Start()
    {
        playerAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();

        //�����
        if (Input.GetMouseButtonDown(0) && !playerAnimator.GetCurrentAnimatorStateInfo(1).IsName("DefaultAttack"))
        {
        
            playerAnimator.SetTrigger("Attack");
        }
        //������
        if (Input.GetButtonDown("Jump") && controller.isGrounded)
        {
            playerAnimator.SetBool("Jump", true);
        }
        else
        {
            playerAnimator.SetBool("Jump", false);
        }
      
        if (!playerAnimator.GetCurrentAnimatorStateInfo(1).IsName("DefaultAttack"))
        {

        
        //������
        //������
        if (Input.GetButton("Vertical") && Input.GetAxis("Vertical") > 0 && !Input.GetButton("Horizontal") && !Input.GetKey(KeyCode.LeftShift))
        {
            playerAnimator.SetBool("ForwardWalk", true);

        }
        else
        {
            playerAnimator.SetBool("ForwardWalk", false);
        }
        // �����
        if (Input.GetButton("Vertical") && Input.GetAxis("Vertical") < 0 && !Input.GetButton("Horizontal") && !Input.GetKey(KeyCode.LeftShift))
        {

            playerAnimator.SetBool("BackwardWalk", true);

        }
        else
        {
            playerAnimator.SetBool("BackwardWalk", false);
        }

        // ������
        if (Input.GetButton("Horizontal") && Input.GetAxis("Horizontal") < 0 && !Input.GetButton("Vertical") && !Input.GetKey(KeyCode.LeftShift))
        {

            playerAnimator.SetBool("LeftWalk", true);

        }
        else
        {
            playerAnimator.SetBool("LeftWalk", false);
        }
        //�������
        if (Input.GetButton("Horizontal") && Input.GetAxis("Horizontal") > 0 && !Input.GetButton("Vertical") && !Input.GetKey(KeyCode.LeftShift))
        {
            playerAnimator.SetBool("RightWalk", true);

        }
        else
        {
            playerAnimator.SetBool("RightWalk", false);
        }

        //������ �������
        if (Input.GetButton("Vertical") && Input.GetAxis("Vertical") > 0 && Input.GetButton("Horizontal") && Input.GetAxis("Horizontal") > 0 && !Input.GetKey(KeyCode.LeftShift))
        {
            playerAnimator.SetBool("ForwardRightWalk", true);

        }
        else
        {
            playerAnimator.SetBool("ForwardRightWalk", false);
        }
        //������ ������
        if (Input.GetButton("Vertical") && Input.GetAxis("Vertical") > 0 && Input.GetButton("Horizontal") && Input.GetAxis("Horizontal") < 0 && !Input.GetKey(KeyCode.LeftShift))
        {
            playerAnimator.SetBool("ForwardLeftWalk", true);

        }
        else
        {
            playerAnimator.SetBool("ForwardLeftWalk", false);
        }

        //����� �������
        if (Input.GetButton("Vertical") && Input.GetAxis("Vertical") < 0 && Input.GetButton("Horizontal") && Input.GetAxis("Horizontal") > 0 && !Input.GetKey(KeyCode.LeftShift))
        {
            playerAnimator.SetBool("BackwardRightWalk", true);

        }
        else
        {
            playerAnimator.SetBool("BackwardRightWalk", false);
        }
        //����� ������
        if (Input.GetButton("Vertical") && Input.GetAxis("Vertical") < 0 && Input.GetButton("Horizontal") && Input.GetAxis("Horizontal") < 0 && !Input.GetKey(KeyCode.LeftShift))
        {
            playerAnimator.SetBool("BackwardLeftWalk", true);

        }
        else
        {
            playerAnimator.SetBool("BackwardLeftWalk", false);
        }

        //<���
        //������
        if (Input.GetButton("Vertical") && Input.GetAxis("Vertical") > 0 && !Input.GetButton("Horizontal") && Input.GetKey(KeyCode.LeftShift))
        {
            playerAnimator.SetBool("ForwardRun", true);

        }
        else
        {
            playerAnimator.SetBool("ForwardRun", false);
        }
        // �����
        if (Input.GetButton("Vertical") && Input.GetAxis("Vertical") < 0 && !Input.GetButton("Horizontal") && Input.GetKey(KeyCode.LeftShift))
        {

            playerAnimator.SetBool("BackwardRun", true);

        }
        else
        {
            playerAnimator.SetBool("BackwardRun", false);
        }

        // ������
        if (Input.GetButton("Horizontal") && Input.GetAxis("Horizontal") < 0 && !Input.GetButton("Vertical") && Input.GetKey(KeyCode.LeftShift))
        {

            playerAnimator.SetBool("LeftRun", true);

        }
        else
        {
            playerAnimator.SetBool("LeftRun", false);
        }
        //�������
        if (Input.GetButton("Horizontal") && Input.GetAxis("Horizontal") > 0 && !Input.GetButton("Vertical") && Input.GetKey(KeyCode.LeftShift))
        {
            playerAnimator.SetBool("RightRun", true);

        }
        else
        {
            playerAnimator.SetBool("RightRun", false);
        }

        //������ �������
        if (Input.GetButton("Vertical") && Input.GetAxis("Vertical") > 0 && Input.GetButton("Horizontal") && Input.GetAxis("Horizontal") > 0 && Input.GetKey(KeyCode.LeftShift))
        {
            playerAnimator.SetBool("ForwardRightRun", true);

        }
        else
        {
            playerAnimator.SetBool("ForwardRightRun", false);
        }
        //������ ������
        if (Input.GetButton("Vertical") && Input.GetAxis("Vertical") > 0 && Input.GetButton("Horizontal") && Input.GetAxis("Horizontal") < 0 && Input.GetKey(KeyCode.LeftShift))
        {
            playerAnimator.SetBool("ForwardLeftRun", true);

        }
        else
        {
            playerAnimator.SetBool("ForwardLeftRun", false);
        }

        //����� �������
        if (Input.GetButton("Vertical") && Input.GetAxis("Vertical") < 0 && Input.GetButton("Horizontal") && Input.GetAxis("Horizontal") > 0 && Input.GetKey(KeyCode.LeftShift))
        {
            playerAnimator.SetBool("BackwardRightRun", true);

        }
        else
        {
            playerAnimator.SetBool("BackwardRightRun", false);
        }
        //����� ������
        if (Input.GetButton("Vertical") && Input.GetAxis("Vertical") < 0 && Input.GetButton("Horizontal") && Input.GetAxis("Horizontal") < 0 && Input.GetKey(KeyCode.LeftShift))
        {
            playerAnimator.SetBool("BackwardLeftRun", true);

        }
        else
        {
            playerAnimator.SetBool("BackwardLeftRun", false);
        }
        }
    }
    public void GetHitAndPushToRightAnimation()
    {
        playerAnimator.SetTrigger("GetHitAndPushToRight");
    }
    public void GetHitAndPushToLeftAnimation()
    {
        playerAnimator.SetTrigger("GetHitAndPushToLeft");
    }
}
