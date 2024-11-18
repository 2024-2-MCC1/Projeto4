using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class next_page : MonoBehaviour
{
    
    void Reset_Here()

    {

        if (GetComponent<Diario>().m == true) { GetComponent<Diario>().n = true; }
        if (GetComponent<Diario>().l == true) { GetComponent<Diario>().m = true; }
        if (GetComponent<Diario>().k == true) { GetComponent<Diario>().l = true; }
        if (GetComponent<Diario>().j == true) { GetComponent<Diario>().k = true; }
        if (GetComponent<Diario>().i == true) { GetComponent<Diario>().i = true; }
        if (GetComponent<Diario>().h == true) { GetComponent<Diario>().j = true; }
        if (GetComponent<Diario>().g == true) { GetComponent<Diario>().h = true;}
        if (GetComponent<Diario>().f == true) { GetComponent<Diario>().g = true;}
        if (GetComponent<Diario>().e == true) { GetComponent<Diario>().f = true;}
        if (GetComponent<Diario>().d == true) { GetComponent<Diario>().e = true;}
        if (GetComponent<Diario>().c == true) { GetComponent<Diario>().d = true;}
        if (GetComponent<Diario>().b == true) { GetComponent<Diario>().c = true;}
        if (GetComponent<Diario>().a == true) { GetComponent<Diario>().b = true;}

        

        

        GetComponent<Diario>().Next = true;
        
        if (GetComponent <Diario>().b == true)
        {
            GetComponent<Diario>().a = true;
            
        }
 
    }
}
