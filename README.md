# BD II

### markdown magic

Witamy w projekcie z baz danych. Za³o¿eniem projektu jest stworzenie bazy danych dla przychodni.

Formatka doktora jest mniej wiêcej gotowa, zapraszam do sprawdzenia czy jest ok, to porefaktoryzuje (__~miszcz__)

TODO:
1. Stworzyæ i do³¹czyæ formatki dla (obecnie nie ma dla nich nic):
* asystenta laboratorium (lechu)
* kierownika laboratorium (lechu?)
2. Dokoñczyæ formatkê dla registratorki (jest tam du¿o zrobione, a ja nie ogariam jeszcze co __~miszczu__)
3. Hopsa do Augustyna na prezêtacyjê

Notatki z ostatniego spotkania (Niektóre s¹ niezrozumia³e, za co przepraszam. Sam czasem nie rozumiem o co biega³o, ale myœlê ¿e wymó¿d¿ymy jakoœ znaczenie __~miszczu__):

TODO: Wykonaæ i pokazaæ ekrany do koñca
 
* Przycisk na query w formie - ¿eby nie szukaæ za du¿o
* Search w formie registratorki o pacjentach
* Sekcja pacjentów/wizyt: Adresy wskazuj¹ na aktualny adres
* Okna edycji - przepisuj¹ siê dane (np. gdy dodajemy u¿ytkownika to username, albo przy edycji istniej¹cego powinny siê przepisaæ aktualne)
* Grid jest niewygodny do edycji pojedynczych pól
* Ludzie nie lubi¹ uzupe³niaæ tabelek, no chyba ¿e liczbami
* Przyciski show
* Tryby formatek - na "Done" ma byæ inna akcja. Decydowaæ ma o tym enum z akcjami
* Show dialogue mo¿e zwracaæ rezultat, bo jak wracamy, to odœwie¿amy
* Odœwie¿amy na Done, na cancel nie
* Porada u lekarza X minut - ka¿da porada ma inny i to jest parametr
* Po wybaniu lekarza nastêpuje konfiguracja slotów. Wybieramy dzieñ -> program liczy sloty -> wyœwietla, albo trwale (?)
* Sloty to logika biznesowa (nale¿¹ do Facades)
* Zbiór stanów w jakim mo¿e byæ slot to wszystkie mo¿liwe stany wizyt + "wolny" ("Add"/"Free")
* Przycisk "Poka¿"
* Cancel to nie jest remove bo remove usuwa, cancel powoduje zwrot dokumentow w recepcji
* Lekarze na liœcie, nie w boxach
* NIE wprowadzaæ wszystkich informacji na jednej formatce
* Tryby tygodniowe - wtedy grid musi siê zmieniæ