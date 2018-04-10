Möjligtvis kan det vara redundant att göra en array med fördefinierade antal platser om man inte vet hur stor arrayen ska vara när man väl använder koden.

I metoden "push" returneras this, jämfört med de andra metoderna som returnerar objekt. Detta kan motiveras tydligare.

I metoden "pop" tas inte objektet ut ur stacken utan endast räknaren minskar med ett och det som returneras är vilket objekt man har tagit bort. Objketet utgör alltså fortfarande en plats på stacken. I och med att det är 1000 platser kan det uppstå problem om man har poppat och sedan vill lägga till nya objekt som då skulle hamna utanför utrymmet i arrayen. Då måste man hantera detta med exceptions.

Lambdauttrycket i "contains" skulle kunna förklaras lite med en kommentar då det kan tyckas vara mer svårläst än övrig kod.

I övrigt tydligt indenterat och bra variabelnamn.
