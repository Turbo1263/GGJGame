using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineCartLauncher : MonoBehaviour
{
    [SerializeField]
    private GameObject mineCart;
    //private Rigidbody rb;
    [SerializeField]
    private float cartSpeed;
    [SerializeField]
    private Transform pof;

    IEnumerator Shoot()
    {
        GameObject cart = Instantiate(mineCart, pof.position, Quaternion.identity);

        Rigidbody rb = cart.AddComponent<Rigidbody>();
        rb.velocity = cartSpeed * pof.forward;
        rb.mass = 25f;

        yield return new WaitForSeconds(7.5f);

        StartCoroutine(Shoot());
    }

    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine(Shoot());
    }
}
