Data: 29.06.2017
Przedmiot: Bazy Danych II, sekcja GDZ2RA5
Projekt: Przychodnia / Clinic
Sk³ad sekcji:
	Gzik Leszek
	Kundera Krzysztof
	Siwiec Micha³
	Szafirski £ukasz
	Ziêtek Kamil


HOW TO GENERATE A BRAND NEW CLINIC DATABASE

1. Open SQL Management Studio
2. Choose "File" -> "Open file" and choose "generate_db_script.sql"
3. Change the ldf and mdf filepaths so they match what you want (preferably a new folder)
4. "Execute"
5. You have a new database. Now it's time to add values.
6. Open "insert_into_database_script.sql"
7. "Execute" - voila, database is full of data. Now configure connecion to database.
8a. If using pre-compiled version of client: edit ConnectionString in "Clinic.Interface.exe.config" (default: (local))
8b. If using project opened in Visual Studio: edit ConnectionStrong in Settings.settings inside project Clinic.Data
9. Enjoy working Clinic application!