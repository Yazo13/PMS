# 🏥 Patient Management System (P.M.S.)

## 📝 Project Overview
This project is a Windows Forms application developed in C# for managing patient records. It demonstrates proficiency in object-oriented programming, data handling with MS SQL Server using Stored Procedures, and adherence to specific refactoring requirements (N1 & N2 tasks).

## ✨ Key Features & Task Completion
The following features were implemented and/or corrected:

* **Data Persistence:** All CRUD operations (Create, Read, Update, Delete) are executed via **Stored Procedures** (`Patient_Save`, `Patient_GetAll`, etc.).
* **Soft Delete (N1):** The 'Delete' operation now uses the `IsDeleted` flag instead of physically removing data from the database.
* **New Fields (N2):** Integrated `PersonalNumber` and `EMail` fields into the database, application logic, and user interface.
* **Validation:** Custom validation added for Personal ID (must be 11 digits if provided) and EMail format.
* **UI/UX:** All grid headers and labels are localized to Georgian.

## 🖼️ Application Demonstration

### Main Patient Grid
*Confirmation of all required data fields and Georgian headers.*

![Main DataGrid View](images/main_grid.png)

### Patient Addition/Editing Form
*Showing the integration of the new Personal Number and EMail fields.*

![Add Patient Form](images/add_form.png)

---

## ⚙️ Tech Stack
* **Language:** C#
* **Framework:** .NET Framework (Windows Forms)
* **Database:** Microsoft SQL Server
* **Version Control:** Git

## 🚀 Setup Instructions
1.  **Database:** Execute the provided `full_sql_script.sql` in MS SQL Management Studio to create the `PMS_Database` and all necessary tables/Stored Procedures.
2.  **Connection String:** Update the connection string (`_connString`) in `PatientMainForm.cs` (or equivalent location) to point to your local SQL Server instance.
3.  **Run:** Open the solution in Visual Studio and run the project.