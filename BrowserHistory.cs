using System;
using System.Collections.Generic;

class BrowserHistory {
    private Stack<string> history = new Stack<string>();
    
    public void VisitPage(string url) {
        history.Push(url);
        Console.WriteLine($"Visitando: {url}");
    }
    
    public void GoBack() {
        if(history.Count > 1) {
            history.Pop();
            Console.WriteLine($"Voltando para: {history.Peek()}");
        } else {
            Console.WriteLine("Nenhuma página anterior");
        }
    }
}
