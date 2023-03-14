using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    public AudioSource walking, Running;
    Animator playerAnim;



    // Start is called before the first frame update
    void Start()
    {
        //playerAnim = GetComponent<Animator>();
    }
    private void OnEnable()
    {
        //playerAnim.SetBool("RunPlayer", false);
        //playerAnim.SetBool("RunSpeed", false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            walking.enabled = true;
            //playerAnim.SetBool("RunPlayer", true);
            //playerAnim.SetBool("RunSpeed", false);

            if (Input.GetKey(KeyCode.LeftShift))
            {
                //playerAnim.SetBool("RunPlayer", false);
                //playerAnim.SetBool("RunSpeed", true);
                walking.enabled = false;
                Running.enabled = true;
            }
            else
            {
                Running.enabled = false;
            }
        }
        else
        {
            walking.enabled = false;
            Running.enabled = false;
            //playerAnim.SetBool("RunPlayer", false);
            //playerAnim.SetBool("RunSpeed", false);

        }
    }

}
