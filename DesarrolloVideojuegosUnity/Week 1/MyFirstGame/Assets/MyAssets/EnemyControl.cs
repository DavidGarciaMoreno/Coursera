using UnityEngine;
using System.Collections;

public class EnemyControl : MonoBehaviour {
  public float velocity = -1f;
  Rigidbody2D rigitBody;

	// Use this for initialization
	void Start () {
    rigitBody = GetComponent<Rigidbody2D>();
	}
	
	void FixedUpdate () {
    Vector2 v = new Vector2(velocity, 0);
    rigitBody.velocity = v;
	}
}
