# Hospital System

### TABLE OF CONTENTS  

1. INTRODUCTION 
1. Maintain Basic Data 
2. Issue query subSystems 
3. Perform Transactions 
4. Entity Relationship Diagram 
5. Mapping 
6. Database Relationships and Tables with Sample Data
7. Input and Output interface 
8. Queries 

 

## 1. INTRODUCTION 
The Hospital Management System is a comprehensive database system
project that aims to streamline and optimize the management of doctors,
patients, and diagnosis information within a healthcare facility. This project is
designed to enhance the efficiency, accuracy, and accessibility of storing,
retrieving, and analyzing data related to medical professionals, patients, and
their diagnoses. 
Technologies Used:
The project utilizes the following technologies to achieve its objectives:
1. Relational Database Management System (RDBMS): The system employs
an RDBMS such as SQL to store and manage the hospital's data
efficiently. The relational model ensures data integrity, consistency, and
flexibility in managing complex relationships between doctors, patients,
and diagnoses.
2. SQL: Structured Query Language (SQL) is used to define the database
schema, perform data manipulation, and execute complex queries for
retrieving and analyzing data. SQL provides a standardized and efficient
way to interact with the database.
3. Programming Language: The project is developed using a programming
language such as Python or Java to implement the user interface,
business logic, and database interactions. This enables the creation of a
user-friendly interface and seamless integration with the database.

### Conclusion:
The Hospital Management System Database System project aims to
revolutionize the way hospitals manage their operations and patient
information. By leveraging a well-designed database schema and
utilizing SQL, the system enhances efficiency, accuracy, and accessibility
in managing doctors, patients, and diagnosis information. This
ultimately improves patient care, streamlines administrative processes,
and supports evidence-based decision-making within the healthcare
facility.
 

 
### Functional View 
1. Maintain Basic Data
• Doctor (Docid(pk) , DocName , Docgen , Experience , Licensce) 
• Patient (PId(pk) , PName , PAddress , PAge , PPhone , pGen ,
BloodGroup , MajorDisease , DocId) 
• Diagnosis (Did(pk) , PatientId , PatientName , Symptoms ,
DiagnosticTest , Medicines , DocId) 
 
## 2. Issue query subSystems 
• Search by Patient ID
• Search by Doctor ID
• Search by Diagnosis ID 
## 3. Perform Transactions 
• Add, delete, and update (all entities).
 
 
## 4. Entity Relationship Diagram  
 
![image](https://github.com/NourSafwan/hospital_system/assets/95777628/9b93a135-0368-43ab-9b03-a0371c5701f0)

 
## 5. Mapping 

 
![image](https://github.com/NourSafwan/hospital_system/assets/95777628/4753b41e-282b-4831-8187-6c3398017b92)
 
 
 
## 6. Database Relationships and Tables with Sample Data 

 

![image](https://github.com/NourSafwan/hospital_system/assets/95777628/e18e518a-b8cc-486b-9d2a-d201a7bbad59)



## 7. Input and Output interface 

![image](https://github.com/NourSafwan/hospital_system/assets/95777628/01c919ed-9878-4c17-937e-1b721626183a)

Login Page for authenticate 1
 
![image](https://github.com/NourSafwan/hospital_system/assets/95777628/023090c0-cbc0-425e-826c-ffa31db89c5b)

 
Home Page for Transaction between Pages  1 
 
![image](https://github.com/NourSafwan/hospital_system/assets/95777628/79e0c5e6-e4cf-49d7-b3b6-e3e05dff8660)
 
 
Doctor Page for registration of doctors 1
 
 ![image](https://github.com/NourSafwan/hospital_system/assets/95777628/547e5d0d-4377-4a62-9ad0-afb4ac0ca340)

 
Patient Page for registration of patient 1
 
![image](https://github.com/NourSafwan/hospital_system/assets/95777628/c3d26380-ff6e-41f3-be8e-c8058a2aa9fc)

Diagnosis Page for Diagnosis register 1
 
![image](https://github.com/NourSafwan/hospital_system/assets/95777628/91a08045-b4ba-4c7e-ae64-41978403bc9e)


Action Bottoms  1 
 
 
## 8. Queries


![image](https://github.com/NourSafwan/hospital_system/assets/95777628/023d4819-52d4-4f18-bbb4-e3f325156371)

 
Doctors Tables in SQL server 1 

![image](https://github.com/NourSafwan/hospital_system/assets/95777628/184f4d41-3257-4023-9dfa-55a500bfc203)
 
Patient Table in SQL server 1 

![image](https://github.com/NourSafwan/hospital_system/assets/95777628/e9ab2fe9-ad7a-4812-96e0-54d6edcef9ca)

 
Diagnosis Table in SQL server 1 1 
 
 
 
