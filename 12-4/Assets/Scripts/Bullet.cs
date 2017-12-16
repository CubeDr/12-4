using UnityEngine;

public class Bullet : MonoBehaviour {
    private Vector3 _target;
    private Vector3 direction; // 단워 벡터
    public Vector3 target {
        get {
            return _target;
        }
        set {
            _target = value;
            direction = (_target - transform.position).normalized;
            transform.LookAt(_target);
        }
    }
    public float speed = 10;

	// Update is called once per frame
	void Update () {
        transform.position += direction * speed * Time.deltaTime;
	}
}
