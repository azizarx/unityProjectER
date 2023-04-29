using UnityEngine;

public class PlaneGenerator : MonoBehaviour
{
    public GameObject planePrefab;
    public int planeCount = 1;
    public float planeSize = 10f;
    public float planeSpacing = 400f;
    public Transform player;

    private GameObject[] planes;
    private int currentPlaneIndex;

    void Start()
    {
        planes = new GameObject[planeCount];
        for (int i = 0; i < planeCount; i++)
        {
            Vector3 position = new Vector3(0f, 0f, i * (planeSize + planeSpacing));
            Quaternion rotation = Quaternion.identity;
            planes[i] = Instantiate(planePrefab, position, rotation);
        }
        currentPlaneIndex = 0;
    }

    void Update()
    {
        float playerZ = player.position.z;
        float lastPlaneZ = planes[currentPlaneIndex].transform.position.z - (planeSize + planeSpacing) * 0.5f;
        if (playerZ < lastPlaneZ + 90f)
        {
            planes[currentPlaneIndex].transform.position += -Vector3.forward * (planeCount * (planeSize + planeSpacing));
            currentPlaneIndex = (currentPlaneIndex + 1) % planeCount;
        }
    }
}