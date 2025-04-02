using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
	private	MovementRigidbody2D	movement;
	private	Transform			target;
	private	float				damage;

	public void Setup(Transform target, float damage)
	{
		movement = GetComponent<MovementRigidbody2D>();

		this.target = target;
		this.damage = damage;

		// 유도 기능이 있는 발사체의 경우 이 코드를 Update()에서 호출
		movement.MoveTo((target.position - transform.position).normalized);
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if ( collision.CompareTag("Player") )
		{
			// 플레이어 체력 감소 (현재는 코드가 없음)
			//collision.GetComponent<Player>().TakeDamage(damage);

			Destroy(gameObject);
		}
	}
}

