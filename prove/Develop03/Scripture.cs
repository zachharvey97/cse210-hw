using System;

class Scripture
{
private List<string> _words = new List<string>();
private int _wordsToHide;
private Reference r = new Reference();
private Random rand = new Random();
private Word word = new Word();
private int _count;
private string memorize;

public void parseScripture(string scripture){
    _words = scripture.Split(" ").ToList();
    Memorizer();
    _wordsToHide = _words.Count;
}
public void Display(){
    Memorizer();
    Console.WriteLine(memorize);
}
public void Memorizer(){
    memorize = String.Join(" ", _words.ToArray());
}
    public void setVisibility(){
        bool visible = false;
        int i = 1;
        while(visible == false){
            i = rand.Next((_wordsToHide));
            word.setWord(_words[i]);
            visible = word.getIsVisible();
        }
        
        foreach (var letter in _words[i]){
           _words[i] = _words[i].Replace(letter,'_');
        }
        Memorizer();
        _count = _count + 1;
    }

    public void Scrip(){
        Console.WriteLine($"{r.Ref()} {memorize}");
    }

    public bool isFinished(){
        bool finished = false;
        if (_count == _wordsToHide){
            finished = true;
        }
        return finished;
    }
}