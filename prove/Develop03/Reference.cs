using System;

class Reference
{
    private string _book = "Proverbs";
    private string _chapter = "3";
    private string _verse1 = "5";
    private string _verse2 = "6";

public string Ref(){
    string reference;
    if (_verse2 != ""){
        reference = _book + " " + _chapter + ":" + _verse1 + "-" + _verse2;
    }
    else{reference = _book + " " + _chapter + ":" + _verse1;}
    return reference;
}

}