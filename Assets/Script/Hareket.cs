using UnityEngine;
using System.Collections;
using System;

public class Hareket : MonoBehaviour
{
    //Burak ÜNAL        1511012033
    //Mehmet ALTINDAL   1511012042
    public float donme_suresi = 0.6f;     
    Vector3 scale;                          

    bool donuyormu = false;                  
    float yönX = 0;                   
    float yönZ = 0;                   

    float baslangic_aci = 0;               
    Vector3 baslangic_pozisyon;                       
    float rotationTime = 0;                 
    float radius = 1;

    Quaternion fromRotation;      //dönmeden önce         
    Quaternion toRotation;        // döndükten sonra          

  
    void Start()
    {

        
        scale = transform.lossyScale;

    }

   
    public void Update(float x , float y)
    {


       
        if ((x != 0 || y != 0) && donuyormu!=true)
        {
           yönX = y;                                                            
            yönZ = x;
            baslangic_pozisyon = transform.position;                                             
            fromRotation = transform.rotation;                                         
            transform.Rotate(yönZ * 90, 0, yönX * 90, Space.World);     
            toRotation = transform.rotation;                                            
            transform.rotation = fromRotation;                                          
            setRadius();                                                               
            rotationTime = 0;
            donuyormu = true;                                                            
        }
    }



   public void FixedUpdate()
    {

        if (donuyormu)
        {

            rotationTime += Time.fixedDeltaTime;                                   
            float ratio = Mathf.Lerp(0, 1, rotationTime / donme_suresi);   

            
            float thetaRad = Mathf.Lerp(0, Mathf.PI / 2f, ratio);                  
            float distanceX = -yönX * radius * (Mathf.Cos(baslangic_aci) - Mathf.Cos(baslangic_aci + thetaRad));     
            float distanceY = radius * (Mathf.Sin(baslangic_aci + thetaRad) - Mathf.Sin(baslangic_aci));                        
            float distanceZ = yönZ * radius * (Mathf.Cos(baslangic_aci) - Mathf.Cos(baslangic_aci + thetaRad));          
            transform.position = new Vector3(baslangic_pozisyon.x + distanceX, baslangic_pozisyon.y + distanceY, baslangic_pozisyon.z + distanceZ);        

            
            transform.rotation = Quaternion.Lerp(fromRotation, toRotation, ratio);

           
            if (ratio == 1)
            {
                donuyormu = false;
                yönX = 0;
                yönZ = 0;
                rotationTime = 0;
            }
        }
    }

    void setRadius()
    {

        Vector3 dirVec = new Vector3(0, 0, 0);          
        Vector3 nomVec = Vector3.up;                    

        
        if (yönX != 0)
        {                          
            dirVec = Vector3.right;                     
        }
        else if (yönZ != 0)
        {                   
            dirVec = Vector3.forward;                 
        }

        
        if (Mathf.Abs(Vector3.Dot(transform.right, dirVec)) > 0.99)
        {                       
            if (Mathf.Abs(Vector3.Dot(transform.up, nomVec)) > 0.99)
            {                   
                radius = Mathf.Sqrt(Mathf.Pow(scale.x / 2f, 2f) + Mathf.Pow(scale.y / 2f, 2f));
                baslangic_aci = Mathf.Atan2(scale.y, scale.x);                              
            }
            else if (Mathf.Abs(Vector3.Dot(transform.forward, nomVec)) > 0.99)
            {       
                radius = Mathf.Sqrt(Mathf.Pow(scale.x / 2f, 2f) + Mathf.Pow(scale.z / 2f, 2f));
                baslangic_aci = Mathf.Atan2(scale.z, scale.x);
            }

        }
        else if (Mathf.Abs(Vector3.Dot(transform.up, dirVec)) > 0.99)
        {                   
            if (Mathf.Abs(Vector3.Dot(transform.right, nomVec)) > 0.99)
            {                   
                radius = Mathf.Sqrt(Mathf.Pow(scale.y / 2f, 2f) + Mathf.Pow(scale.x / 2f, 2f));
                baslangic_aci = Mathf.Atan2(scale.x, scale.y);
            }
            else if (Mathf.Abs(Vector3.Dot(transform.forward, nomVec)) > 0.99)
            {       
                radius = Mathf.Sqrt(Mathf.Pow(scale.y / 2f, 2f) + Mathf.Pow(scale.z / 2f, 2f));
                baslangic_aci = Mathf.Atan2(scale.z, scale.y);
            }
        }
        else if (Mathf.Abs(Vector3.Dot(transform.forward, dirVec)) > 0.99)
        {           
            if (Mathf.Abs(Vector3.Dot(transform.right, nomVec)) > 0.99)
            {                
                radius = Mathf.Sqrt(Mathf.Pow(scale.z / 2f, 2f) + Mathf.Pow(scale.x / 2f, 2f));
                baslangic_aci = Mathf.Atan2(scale.x, scale.z);
            }
            else if (Mathf.Abs(Vector3.Dot(transform.up, nomVec)) > 0.99)
            {               
                radius = Mathf.Sqrt(Mathf.Pow(scale.z / 2f, 2f) + Mathf.Pow(scale.y / 2f, 2f));
                baslangic_aci = Mathf.Atan2(scale.y, scale.z);
            }
        }

    }
}