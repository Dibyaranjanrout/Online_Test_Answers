       //////// Written in C# ////////////////////

//// Generic Method which return value based on Objects and keys passed////

private string GetValueFromNestedDictinary(Dictinary<string, Dictinary<string, Dictinary<string,string>>> dicObj,string keyValue)

{
    string[] keysHierachy = keyValue.Split('/');
    dynamic valueOutput = dicObj;
    foreach (var item in keysHierachy) 
    {
        valueOutput = valueOutput[item];

    }

    return valueOutput;
}

//// Example /////

//calling method 
 GetValueFromNestedDictinary(dicObj,"A/B/C"); /// this method will return D as value
 GetValueFromNestedDictinary(dicObj,"X/Y/Z"): /// this method will return A as value

Dictinary<string, Dictinary<string, Dictinary<string,string>>> dicObj = new Dictinary<string, Dictinary<string, Dictinary<string,string>>> 
 
 {
   "A" ,new Dictinary<string, Dictinary<string, string>>
    {
        {
            "B", new Dictinary<string, string>
            {
             {"C","D},
            }
        }
    },
    "X" ,new Dictinary<string, Dictinary<string, string>>
    {
        {
            "Y", new Dictinary<string, string>
            {
             {"Z","A},
            }
        }
    }


 }
