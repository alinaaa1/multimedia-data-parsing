# multimedia-data-parsing
# Sistem Gestiune Muzee Oltenia (C# & Microsoft SQL Server)

Aplicație desktop de tip CRUD dezvoltată în C# (.NET / Windows Forms) conectată la o bază de date Microsoft SQL Server, destinată administrării, filtrării și exportului structurat al datelor în formatele XML și JSON.

---

## 🛠️ Tehnologii utilizate
* **Limbaj:** C# (.NET Framework)
* **Mediu de dezvoltare:** Visual Studio
* **Bază de date:** Microsoft SQL Server (T-SQL, interogări parametrizate)
* **Interfață grafică:** Windows Forms (UI asincron, controale dinamice, ListView)
* **Serializare & Formate date:** XML (`System.Xml.Serialization`), JSON

---

## 📌 Ce face aplicația
* **Autentificare & Securitate:** Modul de conectare și înregistrare utilizatori direct în baza de date.
* **Operații CRUD complete:** Inserare, afișare, căutare dinamică la tastare și ștergere securizată cu dialog de confirmare.
* **Prevenire SQL Injection:** Toate interogările către SQL Server folosesc parametri dedicați (`SqlParameter`).
* **Interfață intuitivă:** 
  * Căutare live în lista de muzee pe măsură ce se tastează.
  * Formatare vizuală pentru preț (`Lei`) și rating afișat sub formă de steluțe grafice.
  * Sortare alfabetică A-Z a înregistrărilor.
* **Modul de export (XML & JSON):** Serializarea listei de obiecte pe baza modelului `Muzeu.cs` și salvarea fișierelor pe disc prin `SaveFileDialog`.

---

## 📁 Structura proiectului
* `Muzeu.cs` – Clasa model de date pentru mapare și serializare.
* `DBHelper.cs` – Clasa pentru conectare SQL și execuția asincronă a comenzilor.
* `MainForm.cs` & `ManageFilesForm.cs` – Logica formularelor și interacțiunea cu utilizatorul.
* `LoginForm.cs` – Gestiunea fluxului de autentificare.
* `ProiectEAV_Muzee.sln` – Soluția completă de Visual Studio.
