using UnityEngine;

public class MagnetCollider : MonoBehaviour
{
[SerializeField]
private Transform character;
private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("coin"))
        {
            CoinFollow coinFollow = other.GetComponent<CoinFollow>();
            if (coinFollow != null)
            {
                coinFollow.startFollowing(character);
            }
        }
    }
}
