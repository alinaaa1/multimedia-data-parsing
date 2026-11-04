# multimedia-data-parsing
# Sistem Gestiune Muzee Oltenia (C# & Microsoft SQL Server)

Aplicație desktop de tip CRUD dezvoltată în C# (.NET / Windows Forms) conectată la o bază de date Microsoft SQL Server, destinată administrării, filtrării și exportului structurat al datelor în formatele XML și JSON.

---

## 🛠️ Tehnologii utilizate
* **Limbaj:** C# (.NET Framework)[cite: 16]
* **Mediu de dezvoltare:** Visual Studio[cite: 16]
* **Bază de date:** Microsoft SQL Server (T-SQL, interogări parametrizate)[cite: 16, 24]
* **Interfață grafică:** Windows Forms (UI asincron, controale dinamice, ListView)[cite: 18, 23, 24]
* **Serializare & Formate date:** XML (`System.Xml.Serialization`), JSON[cite: 13, 30]

---

## 📌 Ce face aplicația
* **Autentificare & Securitate:** Modul de conectare și înregistrare utilizatori direct în baza de date[cite: 17, 18].
* **Operații CRUD complete:** Inserare, afișare, căutare dinamică la tastare și ștergere securizată cu dialog de confirmare[cite: 20, 24, 25, 26].
* **Prevenire SQL Injection:** Toate interogările către SQL Server folosesc parametri dedicați (`SqlParameter`)[cite: 24].
* **Interfață intuitivă:** 
  * Căutare live în lista de muzee pe măsură ce se tastează[cite: 22, 25].
  * Formatare vizuală pentru preț (`Lei`) și rating afișat sub formă de steluțe grafice[cite: 23].
  * Sortare alfabetică A-Z a înregistrărilor[cite: 21].
* **Modul de export (XML & JSON):** Serializarea listei de obiecte pe baza modelului `Muzeu.cs` și salvarea fișierelor pe disc prin `SaveFileDialog`[cite: 29, 30].

---

## 📁 Structura proiectului
* `Muzeu.cs` – Clasa model de date pentru mapare și serializare[cite: 29].
* `DBHelper.cs` – Clasa pentru conectare SQL și execuția asincronă a comenzilor[cite: 26, 30].
* `MainForm.cs` & `ManageFilesForm.cs` – Logica formularelor și interacțiunea cu utilizatorul[cite: 33].
* `LoginForm.cs` – Gestiunea fluxului de autentificare[cite: 33].
* `ProiectEAV_Muzee.sln` – Soluția completă de Visual Studio[cite: 33].
