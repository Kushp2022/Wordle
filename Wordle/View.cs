/**
* <View.cs>
* <Kush Patel / Thursday 4:30 - 6:20>
*
Extra Credit Included

* This class is in charge of printing and reciving input. This class asks the level the user wants then it scans the txt file and stores 
it in an arrylist. this class dosent do much only communicate with the user through the Controller. 
*/
using System;
using System.IO;
using System.Collections;

public class View{
    public ArrayList wordsList = new ArrayList();

    public string getFirst(){
        Console.WriteLine("B: Beginner-6 Rows \nP: Proficient-4 Rows \nE: Expert-3 Rows ");
        Console.Write("Enter Skill Level (B, P or E): ");
        string k = Console.ReadLine();
        string kupper = k.ToUpper();
        return kupper;
    }

    public void readFile(){
    using (StreamReader reader = new StreamReader("words.txt"))
    {
        string line;
        int count = 0;
        while ((line = reader.ReadLine()) != null)
        {
            if (count != 0 && line.Length == 5)
            {
                this.wordsList.Add(line);
            }
            count++;
        }
    }
}


    public ArrayList GetWordsList() {
        return wordsList;
    }

    public void print(string s){
        Console.WriteLine(s);
    }
    
    public bool playAgain(){
        Console.Write("Would you like to play again (Y)es or (N)o?  ");
        string m = Console.ReadLine();
        string mupper = m.ToUpper();
        if(mupper == "Y"){
            return true;
        }
        else{
            return false;
        }
    }

    public string enterguess(int i){
        int un = i + 1;
        Console.Write("\nEnter guess "+ un + ": ");
        string guess = Console.ReadLine();
        string guesupper = guess.ToUpper();
        return guesupper;
    }
    public void p(string k){
        Console.WriteLine(k);
    }
    public void win(){
        Console.WriteLine("\nYou Win");
    }
    public void lose(){
        Console.WriteLine("\nYou Lose");
    }

}