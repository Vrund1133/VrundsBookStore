14th November 2022

=========================================================Assignment-2 Part-1=========================================================

0338: I created the application first time on November 9th and on that date I also completed Part-2 but I was facing some issues with category table. Content was not showing on the table so, I deleted the repository on the GitHub 
		and starting the assignment from the begining.

0341: I checked the _ViewsStart.cshtml file as showed in the Assignment 1 file.

0350: I started editing the Startup.cs file and make some changes in the code as per the assignment file.

0352: Now I am going to create the GitHub repo for my application.

0353: I created the repo and push it on my GitHub.

0355: Moving to  1.2-Review. I started reviewing the file. 

0355: Review the HomeController.cs file in the COntrollers folder.

0358: Reviewed all the files in the View/Shared/ folder and _viewImports.cshtml and _Viewstart.cshtml file.

0402: Moving to 1.2 Debugging. 

0405: Added two breakpoints in the HomeController.cs File on IActionIndex and Privacy. Now I am going to run the program.

0409: Run the program successfully as showed in the assignment file. Completed 1.2.

0413: Moving to 1.3 Bootstrap.

0413: I downloaded my favourite bootstrap.css file from Bootswatch.com and I am going to replace it in the wwwroot/lib/bootstrap/dist/css/ folder.

0417: I replaced the bootstrap.css file and now I am going to replace the site.css file content with the provided file in the Assignment-2 Folder.

0421: I replaced the site.css and I also edited the _cfile in the Views folder.

0423: Now I am going to edit the _LoginPartial.cshtml file. Removed all the 'text-dark' references from this file.

0425: Run the program successfully but I had to run it by cuntinuing 2 time because of the break points I inserted earlier. For now I am ignoring this problem.

0430: I started editing _Layout.cshtml file by adding css link from CSS_JS.txt file. added all the links.

0433: Now I am adding dropdown menu. 

0440: Added the dropdown to the menu from the provided bootstrap link and run the program successfully. Changed the Dropdown name to 'Content Manager'.

0445: Completed 1.3. Now moving to 1.4-Add Projects & Modify.

0450: Created three new .NET Core Class Library to the application one by one.

0456: Copy and pasted the Data folder to .DataAccess project and deleted teh original one.

0457: Installed two Microsoft entity frameworks. 1- .Relational and 2- .SqlServer to the .DataAccess project. 

0459: Also Deleted the Migration folder.

0503: To remove the error in ApplicationDbContext.cs file I installed .EntityFrameworkCore and also modified the namespace to reflect the project.

0505: Deleted all the Calss1.cs files from all three Projects. Build teh project successfully.

0510: Moved the Models folder to .Models Project and deletd the original one.

0511: Added the references for .DataAccess and .Models to VrundBooksStore Project. Also renamed the Models folder to 'ViewModels'.

0512: Build the Project successfully.

0518: Modifiy the Startup.cs service, Added context with using statement. Also removed one using statement.

0519: Corrected Default .ErrorViewModel reference and solved another error by doing this. Run the application successfully without any error.

0523: Added the references to the main project and for .DataAccess I added .Models and .Utility references to the project.

0534: Added Customer areas to the Areas and changed the routs in the Startup.cs and ScaffoldingReadMe.txt.

0535: Moved the HomeController.cs to the Area/Customer/Controller folder and deleted the Data and Models folder. Edited this file.

0537: Moved the Home folder to Areas/Views and edited the namespace.

0538: Run the program successfully.

0549: Added the Admin area to the Areas folder and added the view files in the view folder and deleted the Data and Models Folder.

0550: Also deleted the Contoller folder. Now I am going to run the application.

0551: Application is running successfully and with that Assignment-2 Part-1 is completed.

*****************************************************Part-1 Ended*********************************************

14th November 2022

==================================================Assignment-2 Part-2====================================================

0858: Started Assignment-2 Part-2.

0859: Now I am going to start 2.1-Build the DB.

0917: Editing appsetting.json file and named my database 'VrundsBookStore'.

0918: By using Nuget Package Manager I am going to add migration.... but wait I entered new migration command in the default project so it hit the error.

0919: I change the project to .DataAccess and then agian try to add migration....Migration was created successfully - 20221115021515_AddDefaultIdentityMigration.cs

0920: I checked it on the Sql Database. and commiting my code to the github.

0945: The biggest error I was facing is to add the category table to  the  database.... I deleted my whole assignment for this error 
      and again created from the sctretch. 

	  I again faced this error and tried it for 3 times and after thinking I deleted the AddCategoryToDb migration after updating the ApplicationDbContext.cs
	  file and again I added the migration for it and finally the table was created and I can see it to the Sql Database.

0949: Now I am pushing my work to the GitHub.

0950: Now I am moving to 2.2-Repository.

1016: I am creating Repository folder in the .DataAccess project and also creating IRepository Folder to the Repository folder.

1017: Added a new interface called IRepository.cs to the IRepository folder.

1018: After adding the file I am updating the data for the file so it can do all the CRUD oprations.

1019: I am creating new class called Repository.cs in the Repository folder.

1030: I was trying to replace the assignment 2 file but it was hitting errors... so I edited it myself with comparing it to the assignment-2 file. (Repository.cs)

1032: I created new classes named CategoryRepository.cs and ICategoryRepository.cs. ... started modifying first file and getting error 
      in the ICategoryRepository namespace.... then I edited the main namespace in the ICategoryRepository.cs file... 

1054: Also modified ICategoryRepository.cs file and now I am commiting my work to the GitHub.

15th November 2022 

0101: After taking a break I created new Interface called ISP_Call.cs in the IRepository folder and edited the code in it.... also created the
	  a new class Called SP_Call.cs in the Repository folder and added the nessesory code in it.

0104: Again added new interface named IUnitOfWork.cs to IRepository folder and UnitOfWork.cs in Repository folder.... edited both files with
	  nessesory code and tryig to add the reference to the Startup.cs file but there was an error... I tried a lot to find and after half an 
	  hour I get it.... I forgot to make the namespace publi in IUnitOfWork.cs file.

0107: Finally I build the project with zero errors.

0110: Moving to next step 2.3-Category CRUD.

0126: Added new MVC Controller file to the Areas/Views/Category folder and edited with adding nessesory code in it.

0127: Created new class file called Index.cshtml in the Category folder and added html code in it and added the path on the top.

0128: I run the application but face an error... I missed something... I type the wrong path in the Index.cshtml file. 

0130: I corrected the error and run the application again... its working well.

0135: Edited the _Layout.cshtml file... move the Category link to the dropdown menu and run the application... Running successfully.

0159: Edited Index.cshtml file and run the appliation ... now I am going to add the category.js file and write the in that file which is available in 
	  Assignment-2 file.

0201: Run the application successfully...

0202: Added the Upsert.cshtml view in the Category folder and write code in it.

0203: Created two empty view files in the shared folder named _CreateAndBackToListButton.cshtml and _EditAndBackToListButton.cshtml.
	  Edited both files.

0205: added asp-sction in the Upsert.cshtml file. and changed TITLE to @title and run the application successfully.

0222: Created new Upsert POST action method in CategoryController.cs file. Added save and remove method. Also added API call http delete in this class.

0224: Implemented httpdelete in the category.js file  and also added delete functionality which is given in the Assignment-2 file.

0226: Now time to run the application and test it.... Run it successfully and added some content and deleted it successfully.

0227: With this Assignment-2 Part-2 is Completed.

1036: I changed the color in bootsrap.css file because my database color and the table color was same... I changed the color.

***********************************************************Part-2 Ended***********************************************************

11-23-2022

==========================================================Assignment-3 Part-3=====================================================

1147: Starting Part-3.

1148: Starting Assignment 1 Part 3.1 - Cover Type CRUD.

1149: Creating CoverType.cs file in the .Models folder like Category.cs file.


11-24-2022


1205: Added content as shown as in Assignment-2 file.

1218: Added migration to the .DataAccess file.....  20221124051541_AddCoverTypeToDb....
	  The file is empty because its the CoverType is not added to the ApplicationDbContext.cs file.

1221: After adding it I deleted the migration and added migration again and the database is created in the sql server.

1251: Created CoverTypeRepository.cs file in Repository folder and created ICoverTypeRepository.cs in IRepository folder.

1254: Edited Code in both files and fixed all the errors. 

1255: Build the project successfully and pushing to GitHub.

0108: Edited UnitofWork.cs and IUnitofWork.cs in the Repository and IRepository folder. 

0109: Added CoverType in both files and Build the Project.

0109: Project Builded Successfully.
 
0136: Created new Controller file called CoverTypeController.cs in the Areas/Admin/Controller folder.

0137: Edited code in the file. 

0137: Added new folder named CoverType in Area/Admin/Views folder.... added new Razar view file named Index.cshtml and edited the code in it.

0139: Run the application and I can see the CreateNewCoverType but now I have to navigate the link for CoverType Dropdown menu in the _Layout.cshtml file.

0140: I added the link and and Its working Successfully.

0234: Added new covertype.js file in the Js folder.

0239: Added code in the js file and addded the link in the Index.cshtml file.

0240: Test and run the application successfully.

0241: Added IActionResult to the CoverTypeController.cs file.

0241: Added new file named CvUpsert.cshtml in the CoverType folder.... edited the code in it... and added asp-action in the Index.cshtml file.

0243: Now I am going to add POST method in CoverTypeController.cs file.

0244: Now Added the HTTP Delete mothod in the CvUpsert.cshtml file and also added the delete method in the covertype.js file...

0245: Finally I am running the application... Successfully run the application and I can add and delete the recort in the Cover Type CRUD.

0246: Finally completed the Part-3.1 and moving to 3.2.

0330: Starting Part 3.1 - Product CRUD.

