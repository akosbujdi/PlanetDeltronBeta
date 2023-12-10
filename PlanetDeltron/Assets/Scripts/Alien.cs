using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien : MonoBehaviour
{
    private int time = 18;
    Animator animator;
    PlayerController playerController;
    BoxCollider boxCollider;
    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        animator = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider>();
        StartCoroutine(alienAnimation());
    }

    // Update is called once per frame
    void Update()
    {
        if (playerController.isGameOver)
        {
            animator.SetTrigger("PlayerDeath");
            StartCoroutine(waitToDestroy());
        }
    }

    IEnumerator alienAnimation()
    {
        yield return new WaitForSeconds(time);
        animator.SetTrigger("AlienDeath");
        boxCollider.enabled = false;
        StartCoroutine(waitToDestroy());
    }

    IEnumerator waitToDestroy()
    {
        yield return new WaitForSeconds(2.5f);
        Destroy(gameObject);
    }
}
