using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    public GameObject cube;
    public int width, height, large;
    public int seed, detail;

    void Start()
    {
        GenerateMap();
    }

    public void GenerateMap()
    {
        // Limpia el mapa anterior
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }

        for (int x = 0; x < width; x++)
        {
            for (int z = 0; z < large; z++)
            {
                float xCoord = (float)x / detail + seed;
                float zCoord = (float)z / detail + seed;
                height = Mathf.FloorToInt(Mathf.PerlinNoise(xCoord, zCoord) * detail);

                for (int y = 0; y < height; y++)
                {
                    Instantiate(cube, new Vector3(x, y, z), Quaternion.identity, transform);
                }
            }
        }
    }
}
