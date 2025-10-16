# 🏥 Patient Management System

This is a simple desktop application designed for managing patient records. It provides a main grid view to see a list of all patients and a separate form for adding new patients or editing existing ones.

The user interface is fully localized in **Georgian**.


### 🖥️ Main Window (PatientMainForm) Description

### ![Main DataGrid View](images/main_grid.png)

The main application window is a management dashboard designed for patient data oversight and direct manipulation.

The central component is a **DataGridView** which displays all active patient records. This view confirms the project's compliance with technical tasks:
* All column headers are localized to **Georgian** (e.g., ID, პაციენტის გვარი სახელი).
* Data is loaded efficiently via the `Patient_GetAll` Stored Procedure.

The control panel at the top provides essential CRUD functionality:
* **Add (დამატება):** Creates new records.
* **Edit (რედაქტირება):** Loads existing data via the `Patient_GetByID` Stored Procedure.
* **Delete (წაშლა):** Executes the **Soft Delete** logic using the `Patient_SoftDelete` Stored Procedure.
##


### 📝 Secondary Window (Add/Edit Patient Form) Description

### ![Add Form View](images/add_form.png)


This form serves a dual purpose: **adding a new patient** and **editing an existing one**. It demonstrates correct data binding, validation, and Stored Procedure usage for both INSERT and UPDATE operations.

* **Data Load Logic:** When used for **editing**, the form loads existing patient details, including `GenderID`, via the `Patient_GetByID` Stored Procedure, and populates the `Gender` dropdown using the `Gender_GetAll` Stored Procedure.

* **Validation:** On almost every field.
* **Save Logic:** The Save button calls the comprehensive `Patient_Save` Stored Procedure, which handles both inserting new records (`ID` is NULL) and updating existing ones (`ID` is present).

---

## 🛠️ Technology Stack (Assumed)

* **Language:** C#
* **Framework:** Windows Forms (WinForms) 
* **Database:** SQL Server

---

## 🚀 Getting Started

*(Add instructions here on how to compile, run, or install your application.)*

For example:

1.  Clone the repository:
    ```bash
    git clone https://github.com/Yazo13/PMS.git
    ```
2.  Open the project file (`.sln` or similar) in your IDE (e.g., Visual Studio).
3.  Build and run the application.
