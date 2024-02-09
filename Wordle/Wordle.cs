/**
* <Wordle.cs>
* <Kush Patel / Thursday 4:30 - 6:20>
*
Extra Credit Included

* This class communicates with the view and words class. This is my Controller for my MVC. This only communcates with the user
through the view class. Then it passes the infromation the view collects to the words class then displays the results. This class
only narrows down what the user wants by skill leel then lets the view and words class take over. 
*/



using System.Collections;

public class Wordle{

public static void Main(string[] args) {
View view = new View();
Words word = new Words();
view.readFile();

ArrayList myArrayList = view.GetWordsList();



do {
    string level = view.getFirst();
    int i = 0;
    word.rNum(myArrayList); // the random number 
    string random = word.word(myArrayList); // gets the random word
    view.print(random);//prints out the random word

    if (level.Equals("B")) {
        while (i < 6) {
            string gues = view.enterguess(i);
            string res = word.check(random, gues);
            if (res.Contains("*") || res.Contains("-"))
            {
                view.p(res);
            }
            else
            {
                view.win();
                break;
            }
            i++;
            
        }
        if (i >= 6) {
        view.lose();
    }
    }

    if (level.Equals("P")) {
        while (i < 4) {
             string gues = view.enterguess(i);
            string res = word.check(random, gues);
            if (res.Contains("*") || res.Contains("-"))
            {
                view.p(res);
            }
            else
            {
                view.win();
                break;
            }
            i++;
        }
        if (i >= 4) {
        view.lose();
    }
    }

    if (level.Equals("E")) {
        while (i < 3) {
             string gues = view.enterguess(i);
            string res = word.check(random, gues);
            if (res.Contains("*") || res.Contains("-"))
            {
                view.p(res);
            }
            else
            {
                view.win();
                break;
            }
            i++;
        }   
        if (i >= 3) {
        view.lose();
    }
    }
} while (view.playAgain());




}



}