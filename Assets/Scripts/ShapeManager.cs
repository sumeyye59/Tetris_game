using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeManager : MonoBehaviour
{
    [SerializeField] private bool donebilirmi=true;
    private void Start()
    {
        InvokeRepeating("AsagiHareketFNC",0f,.25f);
        InvokeRepeating("SolaDonFNC",0f,.2f);
       //tartCoroutine(HareketRoutine());
    
    }

    public void SolaHareketFNC()
    {
        transform.Translate(Vector3.left,Space.World);
    }
    public void SagHareketFNC()
    {
        transform.Translate(Vector3.right,Space.World);
    }
    public void AsagiHareketFNC()
    {
        transform.Translate(Vector3.down, Space.World);
          
    }
    public void YukariHareketFNC()
    {
        transform.Translate(Vector3.up,Space.World);

    }
    public void SagaDonFNC()
    {
        if (donebilirmi) {
            transform.Rotate(0,0,-90);
        }

    }
    public void SolaDonFNC()
    {

        if (donebilirmi)
        {
            transform.Rotate(0, 0, 90);
        }

    }
    IEnumerator HareketRoutine()
    {
        while (true)
        {
            AsagiHareketFNC();
            yield return new WaitForSeconds(.25f);
        }
    }
}
