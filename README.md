# Feedback Information
Thanks for conducting feedback for my OSP!
You'll need to download this project onto your device, which I'll show you further down this page.

> [!Important]
> For some unknown reason, layouts on some pages sometimes break. Most sections of the website have screenshots on the form anyways, so layouts that have been broken are shown as they're meant to be.
> This might have been due to corruption during compression - but I don't know for definite.

> [!Warning]
> Ticket booking doesn't work! I know exactly what the problem is, but due to the rules of the exam I am not allowed to change it. Still feel free to write about it in your response, though!

## Forms
**There is one form but it's split into sections.** It can be found [here](https://forms.gle/WkTgyGcy69J5R76m8).
If you have knowledge of ASP.Net (or even just C# and HTML in general), please select **"Technical"** on the general page. Otherwise, select **"Non-Technical"**.
Both sections of the survey conists of a regular set of questions. However, Technical particpants will be asked a few extra questions.

## Setting up
1. Open Visual Studio 2022
2. Click "Clone a Repository"
3. Copy and paste the following link into "Repository location" -
   https://github.com/jpelling2006/RigetZooAdventures.git
5. Click "Clone"
6. On the toolbar, click Tools > NuGet Package Manager > Package Manager Console. This should open a terminl at the bottom of your screen.
7. Copy and paste the command ```update-database```
8. The project can now run. Press F5 and it will run.
9. You will need to make an account to access some features. **You don't need to use your real infomation, make up some fake details.**

### Technical only steps:
10. Run the project and type "https://localhost:[port]/Role" (replacing port with the four digits of your port).
11. Click "Create"
12. Use the create page to make three roles called "Customer", "Employee" and "Admin". Use these exact names and do this in the same order.
13. To return the Role Controller to its usual, admin only status, go to Controllers/RoleController.cs and uncomment line 8.
14. To assign roles, make normal Customer accounts via the registration page. Then go to your SQL Object Explorer, view the data in the table AspNetRoles, copy the Id for the role you want to assign.
15. Go to AspNetUsers and find the Id of the user you want to assign the role to.
16. Find that same Id in AspNetUserRoles, and replace the RoleId next to it with the one you just copied.
