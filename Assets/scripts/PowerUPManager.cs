using UnityEngine;

public class PowerUPManager : MonoBehaviour
{
[SerializeField]
private int minPlatformsNumber =5;
[SerializeField]
private int maxPlatformsNumber = 7;
[SerializeField]
private InstantiatePoolObjects[] powerUppools;
[SerializeField]
private float powerUpoffset = 2f;
private int platformsNumber;
private int platformsCounter = 0;
public void Awake() 
{
    SetPlatformsNumber();
}
private void SetPlatformsNumber()
    {
        minPlatformsNumber = Random.Range(minPlatformsNumber, maxPlatformsNumber);
    }
    public void Platformpassed(Platform platform)
    {
        platformsCounter++;
        if (platformsCounter >= platformsNumber)
        {
            SpawnPowerup(platform);
            platformsCounter = 0;
            SetPlatformsNumber();
        }
    }
    private void SpawnPowerup(Platform platform)
    {
        if (!platform.HasCoins()) return;
        InstantiatePoolObjects pool = powerUppools[Random.Range(0, powerUppools.Length)];
        pool.InstantiateObject(Vector3.zero);
        GameObject powerUp = pool.GetCurrentObject();
        platform.AddPowerUp(powerUp);
        powerUp.transform.localPosition += Vector3.up *powerUpoffset;
    }
}
