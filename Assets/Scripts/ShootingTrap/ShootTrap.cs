using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootTrap : MonoBehaviour
{
	[SerializeField]
	private GameObject ItemProjectile;
	[SerializeField]
	private float Delay = 0.1f;
	[SerializeField]
	private float interval = 2f;
	[SerializeField]
	private float destroydelay = 2.5f;

    void Start()
    {
        StartCoroutine(Shoot(Delay));
    }

    private IEnumerator Shoot(float delay)
    {
        yield return new WaitForSeconds(delay + Delay);
        Delay = 0f;
        var item = (GameObject) Instantiate(ItemProjectile, transform.position, transform.rotation);
        Destroy(item, destroydelay);
        StartCoroutine(Shoot(interval));
    }
}
