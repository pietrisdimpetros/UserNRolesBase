# UserNRolesBase
Simple instructions based on Moss tutorial on how it was created up until this particular point
Pending:
1) Add Models
2) Create Role Management Class
3) Add authorization tokens
4) Apply filters
5) Create separate Role views
6) maybe more cant think rn

Steps:
(Read comments)
1) Enable Migrations
2) Account Controller -> Register Action
3)Change authorization to the entire webApp
4) AppStart -> FilterConfig-> add to method Line "filters.Add(new AuthorizeAttribute());"
Change authorization to the entire webApp
5) Go to Home Controller and add above the home controller class and inside the name space the
tag [AllowAnonymous]
6)add-migration and update-database
7)ctrl + f5 to register a guest account  
credentials: Email:guest@usernroles.com
	     Password: Guest202!
8) Close browser/stop app
9) Go to AccountController in the Register section (Async) inside the "if" clause and
add the temporary code
10) Ctrl+f5 and register the administrator user with 
the following credentials: Email:    UserNRoles@usernroles.com
			   Password: RolesAdministrator202!
11) add-migration originalUsersQuery. we will use this empty migration to use as a vessel for an SQL query for the original Users (Guest, Administrator)
12) Go to Solution Explorer-> show all files on top->Go to AppData->Double click the name of the database (UserNRolesBase) wait for loading, rr if needed
13) Inside Server explorer expand the database and under tables find the AspNetUsers table -> right click-> show table data
14) Click on the bar on the left of the row of the table to select the entire row. Select with ctrl both rows (guest and admin)--> right click and 
sript
15) Go to our empty migration from step 11 and copy the script and paste it inside the up method (inside the string quotes in Sql(@"");)
16) repeat steps 13-15 for the AspnetRoles Table this time
17) Lastly repeat steps 13-15 for the AspnetUserRoles Table
18) Now go to tables AspNetUsers and  AspNetRoles one at a time and delete the rows of the tables
19) update-database (now our database is ready,we have an administrator, no deleting migrations and tables from now on)
    All the previous steps are intended to reduce vulnerability
20) Go to solution explorer Account Controller and repeat steps 9 and 10 but this time changing the "Administrator" string to Manager in order to 
create the Manager Role
21) ctrl+f5 to register the Manager with credentials:
Email:ApplicationManager@usernroles.com
Password: ApplicationManager202!
Log off and close app
22) repeat step 21 for Validated Role
Email: FirstValidatedUser@usernroles.com
Password: FirstValidatedUser202!
23) repeat step 21 for Unvalidated Role
Email: FirstUnvalidatedUser@usernroles.com
Password: FirstUnvalidatedUser202! 
