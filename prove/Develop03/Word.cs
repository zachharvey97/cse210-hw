using System;

class Word
{
    private bool _isVisible;
    private string _word;

    public bool getIsVisible(){
        bool visbility;
         if (_word.Substring(0,1) == "_"){
            visbility = false;
         }
         else{
            visbility = true;
         }
         return visbility;
     }

     

    public void setIsVisible(bool isVisible){
        //
    }
    public void setWord(string word){
        _word = word;
    }
}