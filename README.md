# biblotikarien
 Status: Ej inlämnad
Din identitet är synlig under rättning.
Maxpoäng: 2

Sista tidpunkt för inlämning: 1 nov 2019 23:59, 14 dagar kvar

Läs igen hela denna uppdragsbeskrivning noggrant.
Deadline för inlämning: 

00.00, natten mellan fredag den 1:a och Lördag den 2:a november

 
För G krävs följande i inlämningen:

A. Du har planerat din lösning på ett lämpligt sätt.

B. Du har skapat en körbar konsolapplikation i C# ( lösningen kommer att testas i Visual Studio Code. )

C.Du har enskilt planera och skapat en enkel men välstrukturerad applikation med hjälp av språket C#.

D.Du har i ett separat dokument/rapport sammanfattat din lösning och tillvägagångssätt samt värderat hur bra du själv tycker att du lyckats med uppgift.

 
För VG krävs följande i inlämningen:

F. Din struktur skapar förutsättningar för effektivt underhåll och möjlighet till vidareutveckling.

 
Uppgiftsbeskrivning:

Som programmerare har du fått kontakt med ett bibliotek som vill att du gör ett ideellt arbete åt dem.
Du ska skapa ett grundläggande konsolprogram som innehåller funktioner för att söka i biblioteket och registrera nya böcker.

 
Krav:

    Lösningen ska innehålla klassen Book (bok) med minst tre egenskaper: titel, skribent och utgivningsår.
    Bok klassen ska ärvas av minst tre underklasser av böcker. Förslagsvis Roman, Tidskrift och Novellsamling.
    Lösningen ska innehålla en klass kallad Library (bibliotek), som ska innehålla en lista med böcker. Listan måste vara private och andra klasser kan bara integrera med listan med hjälp av metoder.
    Bibliotek-klassen ska ha minst fyra publika metoder.
        En för att lägga till en bok i listan
        En för att lägga till flera böcker samtidigt (en lista med böcker)
        En för av skriva ut alla böcker i biblioteket.
        En för att söka bland böckerna i bokhyllan med en given sträng (indata)
    Varje underklass till bok: tidskrift, roman, novellsamling; ska ha en egen override av ToString metod som ska användas vid utritning. Den metoden ska ge tillbaka olika meddelande beroende på vilken klass det är.
    Användaren ska genom en konsolmeny kunna lägga till nya böcker i listan, skriva ut alla böcker i biblioteket samt kunna söka efter en bok med ett givet namn. Boken ska matcha om det man söker efter finns någonstans i bokens titel, författarens namn eller i utgivningsåret och ska inte vara känsligt för stora eller små bokstäver.
    När användaren skriver ut samtliga böcker eller söker efter böcker ska ToString-metoden kallas.
    Varje bok som användaren sparar i listan ska vara ett eget objekt.
    När programmet skapas ska en färdigkonfiguerad lista av minst 5 böcker av olika typer från början finnas i biblioteket.

 
Tips och riktlinjer:

    Inlämning av uppgiften sker via PingPong, ni behöver inte använda GIT alls i denna uppgift.
    Ni kan dokumentera er lösning (mål D) i readme.md filen eller i ett separat dokument, det ska dock lämnas in digitalt. Det ska inte skrivas på PingPong eller exempelvis ett mail, utan ska vara en del av inlämningen.
    När ni skriver er rapport (mål D), beskriv vad fördelarna är med er struktur? Vad är den ev. problematiken om programmet skulle växa på olika aspekterna.
    Mål A kommer bedömas utifrån er rapport jämte ert kodresultat, Dokumentera med fördel med hjälp av ev. flöde- & klassdiagram eller hur ni från er synvinkel förstått uppgiften.
    All form av koddelning är otillåten och innebär automatiskt U i betyg. Använder ni en färdig lösning från exempelvis Stack Overflow måste ni dokumentera- samt motivera detta i kodkommmentarer.
    Se till att ditt program kan hantera felaktig inmatning och inte kraschar.
    För en bra struktur, tänk på att separera inmatningen av information från bibliotek och bok klasserna. Dom ska alltså inte använda sig av Console någonstans.
    För att veta hur sökning går till behöver ni ev. slå upp och hitta information på nätet. Om ni inte klarar av detta steg så är det viktigaste att ni dokumenterar och reflekterar kring detta i er rapport.
    Inlämningen ska bestå av din mapp innehållande källkod och .csproj fil tillsammans med en separat rapport. Båda filerna ska zippas och lämnas in på PingPong.

 

Lycka till!


Viktor
