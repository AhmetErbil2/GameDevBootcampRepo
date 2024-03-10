using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Ders1Ödev : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        ////////////////////////Yedi Faktoriyel
        int Fak = 1;
        for (int i = 1; i <= 7; i++)
        {
            Fak *= i;
        }

        Debug.Log("7!="+Fak);


        ///////////////////////////////////////1-100 arasındaki sayılardan tek olanları ekrana yazdırın 
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 != 0)
            {
                Debug.Log(i);
            }
        }
        //////////////////////////////////////////////1-100 arasındakı sayılardan cıft olanları ekrana yazdırın
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                Debug.Log(i);
            }
        }

        /////////////////////////////////////////////////1-100'e kadar olan sayıların toplamını ekrana yazdırın 
        int toplam = 0;

        
        for (int i = 1; i <= 100; i++)
        {
            toplam += i;
        }

        
        Debug.Log("1-100'e kadar olan sayıların toplamını ekrana yazdırın: " + toplam);
        //////////////////////////////////////////////////İsim soyisim yaş cinsiyet adres boy kilo bilgilerini ekrana yazdırın
        ///Boy kilo endeksinizi veren bir ekran cıktısı yaptırın
        string İsim = "Ahmet"+"Erbil";
        string Soyİsim = "Yılmaz";
        int Yas = 27;
        float Boy = 178;
        float Kilo = 100;
        float Endeks = Kilo / (Boy * Boy);
        Debug.Log(İsim + Soyİsim + Yas);
        Debug.Log("Vücut Kütle Endeksi"+Endeks);
        ////////////////////////////////////////////////////1-100 arasındakı butun sayılar ekrana tek tek yazdırın
        for (int i = 1; i <= 100; i++)
        {
            Debug.Log(i);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
