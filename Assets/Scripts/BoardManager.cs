using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Transform tilePrefab;
  
    public int yukseklik = 22;
    public int genislik = 10;
    private void Start()
    {
        BosKareleriOlustur();
    }
    void BosKareleriOlustur()
    {
        if (tilePrefab != null)
        {
            for (int y = 0; y < yukseklik; y++)
            {
                for (int x = 0; x < genislik; x++)
                {
                    Transform tile = Instantiate(tilePrefab, position: new Vector3(x, y, z: 0), Quaternion.identity);
                    tile.name = "x " + x.ToString() + "," + y.ToString();
                    tile.parent = this.transform;
                }

            }
        }
        else
        {
            print(message: "tilePrefab eklenmedi!");
        }



    }
}
