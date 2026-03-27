using UnityEngine;

public class CoinFollow : MonoBehaviour
{
private Transform player;
[SerializeField]
private float followSpeed = 5f;
[SerializeField]
private float minumumDistance = 0.1f;
private bool canFollow = true;
private Vector3 originalposition = Vector3.zero;
private void Awake()
    {
        originalposition = transform.localPosition;
    }
    private void OnEnable()
    {
        canFollow = true;
        player = null;
        if (originalposition != Vector3.zero)transform.localPosition = originalposition;
    }
public void startFollowing(Transform playertransform)
    {
        if (!canFollow) return;
        canFollow = false;
        player = playertransform;
    }
public void Update()
    {
    if (player != null)
        {
            Vector3 targetPosition = player.position;
            transform.position = Vector3.Lerp(transform.position, targetPosition, followSpeed * Time.deltaTime);
            if (Vector3.Distance(transform.position, targetPosition) < minumumDistance)
            {
                player.GetComponent<PlayerCollide>()?.CollectCoin(gameObject);
                player = null;
            }
        }
    }
}
