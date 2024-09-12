using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    SpawnerManager spawner;
    BoardManager board;
    private ShapeManager aktifSekil;

    private void Start()
    {

        board = GameObject.FindObjectOfType<BoardManager>();
        spawner = GameObject.FindObjectOfType<SpawnerManager>();
    }
  /*  if(spawner){
           if(aktifSekil==null){
        aktifSekil=spawner.SekilOlusturFNC();
        }
           
}*/

}
