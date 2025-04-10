using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heladeria : MonoBehaviour
{
    public string gusto;
    public int gramos;

    int precioPorKilo = 500;
    // Start is called before the first frame update
    void Start()
    {
        if(gusto != "CHO" && gusto != "FRU" && gusto != "DDL"){
            Debug.Log("escribi un codigo valido como FRU, CHO, DDL");
            return;
        }
        if(gramos < 250 || gramos > 3000){
            Debug.Log("no se puede pedir menos de 250 gramos ni mas de 3000 gramos");
            return;
        }
    float precioPorGramo = (precioPorKilo / 1000f);
    float precioFinal = precioPorGramo * gramos;
    if(gusto == "FRU"){
        precioFinal = precioFinal * 0.9f;
    }
    Debug.Log("el gusto es:" + gusto +" y el precio es:" + precioFinal);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
