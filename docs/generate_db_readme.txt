HOW TO GENERATE A BRAND NEW CLINIC DATABASE

1. Clone repository or download "generate_db_script.sql" and "insert_into_database_script.sql"
2. Open SQL Management Studio
3. Choose "File" -> "Open file" and choose "generate_db_script.sql"
4. Change the ldf and mdf filepaths so they match what you want (preferably a new folder)
5. "Execute"
6. You have a new database. Now it's time to add values.
7. Open "insert_into_database_script.sql"
8. "Execute" - voila, database is full of data. Now configure connecion to database.
9a. If using pre-compiled version of client: edit ConnectionString in "Clinic.Interface.exe.config" (default: (local))
9b. If using project opened in Visual Studio: edit ConnectionStrong in Settings.settings inside project Clinic.Data
10. Enjoy working Clinic application!