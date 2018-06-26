using System;
using System.Collections.Generic;
using System.Text;

// U1
namespace CSharp
{
    public class GetSet
        {
            public GetSet() { }


            // Beispiel 1. FALSCH, keine OOP-Kapselung 
            public string nameSmall;


            // Beispiel 2. Set und Get Methode
            private string nameMid;

            public string GetNameMid()
            {
                return nameMid;
            }

            public void SetNameMid(string NameMid)
            {
                nameMid = NameMid;
            }


            // Beispiel 3. Eigenschaft
            private string name;

            public string Name
            {
                set { name = value; }
                get { return name; }
            }

            /*
            get
            {
               if (Name == "wwww") {  return "aaa"; }
               else { return name; }
            } 
            */


            //  Beispiel 4. Automatische Eigenschaft
            private string nameKurz;

            public string NameKurz
            {
                get;
                set;
            }
        }
}
