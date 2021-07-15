using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deathfall : MonoBehaviour
{
    private bool isTouchingDeath;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsdeath;

    void FixedUpdate()
    {
        isTouchingDeath = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsdeath);
        if (isTouchingDeath == true)
        {
            SceneManager.LoadScene("level1");
        }
    }
}
