using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerManager : MonoBehaviour
{
    [SerializeField] ShapeManager[] tumSekiller;
   
    public ShapeManager SekilOlusturFNC()
    {
        int randomSekil = Random.Range(0, tumSekiller.Length);
        ShapeManager sekil = Instantiate(tumSekiller[randomSekil],transform.position,Quaternion.identity) as ShapeManager;
        if (sekil != null)
        {
            return sekil;
        }
        else {
            print("dizi boþ");
            return null; }
    }

}
