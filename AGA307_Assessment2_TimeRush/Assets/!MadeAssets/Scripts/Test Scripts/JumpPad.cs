using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{


    // Start is called before the first frame update
    public float jumpHeight;
    MovementInput moveScriptRef;
    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        {
            if (other.CompareTag("Player"))
            {
                moveScriptRef = other.GetComponent<MovementInput>();
                moveScriptRef.jumpPadUse = true;
                moveScriptRef.verticalVel =+ jumpHeight;
                Debug.Log("Boing?");
                StartCoroutine(ResetJumpPad());

            }
            else
            {
                Debug.Log("Error");
            }
        }
    }

    IEnumerator ResetJumpPad()
    {
        yield return new WaitForSeconds(1);
        moveScriptRef.jumpPadUse = false;
        Debug.Log("BounceOff");




    }




}
