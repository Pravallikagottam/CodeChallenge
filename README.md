# CodeChallenge

I have considered the normalized form of data

I had trouble creating an mdf file because I am using my work laptop and bcoz of security reasons I am not able to install anything or create an mdf file to work with realdata 

1.	With 1st question of normalizing the data 
I would like to extract all the employee data into 1 table EmployeeInfo containing (Firstname,Lastname,Address,EmployeeId) where employeeId is the primary key with identity seed set to1
EmployeeType will be a lookup/type table where it can contain…all 3 different employee types (employee/Supervisor/Manager) and it is an enum in the api prj

EmployeeFinancials tbl can be the child tbl which can have the fk relationship with emp table and it can hold all the financial data like payperhour, expenses,annual salary.

2.	I mocked with fakedata in the repository/context class and tested it worked with postman.

I would like to setup swagger but unfortunately I couldn’t install the nuget package from package manager




