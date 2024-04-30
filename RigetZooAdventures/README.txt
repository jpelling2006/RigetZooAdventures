You will need to set up for the first-time use of this project.
This text document acts as an easy-to-use guide on how to do so.

1. Open the Packet Manager Console (PMC) and type "update-database". This should create a database called "RigetZooAdventures" on your system, and allow the project to run.
2. Run the project and type "https://localhost:[port]/Role" (replacing port with the four digits of your port).
3. Click "Create"
4. Use the create page to make three roles called "Customer", "Employee" and "Admin". Use these exact names and do this in the same order.
5. To return the Role Controller to its usual, admin only status, go to Controllers/RoleController.cs and uncomment line 8.
6. To assign roles, make normal Customer accounts via the registration page. Then go to your SQL Object Explorer, view the data in the table AspNetRoles, copy the Id for the role you want to assign.
7. Go to AspNetUsers and find the Id of the user you want to assign the role to.
8. Find that same Id in AspNetUserRoles, and replace the RoleId next to it with the one you just copied.