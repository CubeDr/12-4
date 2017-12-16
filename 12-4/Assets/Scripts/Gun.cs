using UnityEngine;

public class Gun : MonoBehaviour {
    public GameObject target;
    public GameObject bulletPrefab;

	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)) {
            Shoot();
        }
	}

    private void Shoot() {
        GameObject bulletObject = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        bulletObject.GetComponent<Bullet>().target = target.transform.position;
    }
}
