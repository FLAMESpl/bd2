# BD II

### markdown magic

Witamy w projekcie z baz danych. Za�o�eniem projektu jest stworzenie bazy danych dla przychodni.

Formatka doktora jest mniej wi�cej gotowa, zapraszam do sprawdzenia czy jest ok, to porefaktoryzuje (__~miszcz__)

TODO:
1. Stworzy� i do��czy� formatki dla (obecnie nie ma dla nich nic):
* asystenta laboratorium (lechu)
* kierownika laboratorium (lechu?)
2. Doko�czy� formatk� dla registratorki (jest tam du�o zrobione, a ja nie ogariam jeszcze co __~miszczu__)
3. Hopsa do Augustyna na prez�tacyj�

Notatki z ostatniego spotkania (Niekt�re s� niezrozumia�e, za co przepraszam. Sam czasem nie rozumiem o co biega�o, ale my�l� �e wym�d�ymy jako� znaczenie __~miszczu__):

TODO: Wykona� i pokaza� ekrany do ko�ca
 
* Przycisk na query w formie - �eby nie szuka� za du�o
* Search w formie registratorki o pacjentach
* Sekcja pacjent�w/wizyt: Adresy wskazuj� na aktualny adres
* Okna edycji - przepisuj� si� dane (np. gdy dodajemy u�ytkownika to username, albo przy edycji istniej�cego powinny si� przepisa� aktualne)
* Grid jest niewygodny do edycji pojedynczych p�l
* Ludzie nie lubi� uzupe�nia� tabelek, no chyba �e liczbami
* Przyciski show
* Tryby formatek - na "Done" ma by� inna akcja. Decydowa� ma o tym enum z akcjami
* Show dialogue mo�e zwraca� rezultat, bo jak wracamy, to od�wie�amy
* Od�wie�amy na Done, na cancel nie
* Porada u lekarza X minut - ka�da porada ma inny i to jest parametr
* Po wybaniu lekarza nast�puje konfiguracja slot�w. Wybieramy dzie� -> program liczy sloty -> wy�wietla, albo trwale (?)
* Sloty to logika biznesowa (nale�� do Facades)
* Zbi�r stan�w w jakim mo�e by� slot to wszystkie mo�liwe stany wizyt + "wolny" ("Add"/"Free")
* Przycisk "Poka�"
* Cancel to nie jest remove bo remove usuwa, cancel powoduje zwrot dokumentow w recepcji
* Lekarze na li�cie, nie w boxach
* NIE wprowadza� wszystkich informacji na jednej formatce
* Tryby tygodniowe - wtedy grid musi si� zmieni�