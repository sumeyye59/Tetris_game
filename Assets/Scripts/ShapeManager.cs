using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeManager : MonoBehaviour
{
    [SerializeField] private bool donebilirmi=true;
    private void Start()
    {
        //InvokeRepeating("AsagiHareketFNC",0f,.25f);
        StartCoroutine(HareketRoutine());
    
    }

    public void SolaHareketFNC()
    {
        transform.Translate(Vector3.left);
    }
    public void SagHareketFNC()
    {
        transform.Translate(Vector3.right);
    }
    public void AsagiHareketFNC()
    {
        transform.Translate(Vector3.down);
          
    }
    public void YukariHareketFNC()
    {
        transform.Translate(Vector3.up);

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
