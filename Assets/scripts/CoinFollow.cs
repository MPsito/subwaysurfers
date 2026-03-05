using UnityEngine;

public class CoinFollow : MonoBehaviour
{
private Transform player;
[SerializeField]
private float followSpeed = 5f;
[SerializeField]
private float minumumDistance = 0.1f;
private bool isfollowing = false;
private Vector3 originalposition;
public void startFollowing(Transform playertransform)
    {
        originalposition = transform.localPosition;
        player = playertransform;
        isfollowing = true;
    }
public void Update()
 {
    if (isfollowing && player != null)
        {
            Vector3 targetPosition = player.position;
            transform.position = Vector3.Lerp(transform.position, targetPosition, followSpeed * Time.deltaTime);
            if (Vector3.Distance(transform.position, targetPosition) < minumumDistance)
            {
                player = null;
                isfollowing = false;
                transform.localPosition = originalposition;
            }
        }
 }
}
