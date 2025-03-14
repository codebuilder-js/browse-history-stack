using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        BrowserHistory browser = new BrowserHistory();
        
        browser.VisitPage("https://google.com");
        browser.VisitPage("https://github.com");
        browser.VisitPage("https://stackoverflow.com");
        
        browser.GoBack();
        browser.GoBack();
        browser.GoBack();
    }
}
