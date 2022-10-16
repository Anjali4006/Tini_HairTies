Date- 14-10-22 .. 11:09 PM 

APPLICATION NAME: Tini_HairTies 

So here We start again!!!! 
Started creating a whole new web application last one had the following error ...

///No suitable constructor found for entity type 'TiniHairTiesContext'. 
The following constructors had parameters that could not be bound to properties 
of the entity type: cannot bind 'options' in 'TiniHairTiesContext(DbContextOptions<TiniHairTiesContext> options)'.///

Created a new README.txt file in the application 
Created a new git repository - Tini_HairTies 
Created a new class file in models folder 
FILE NAME: HairTies.cs 
Added the 7 properties of my product to the file	
Committed code to git hub 

11:17 
Edited indexhtml.cs file 
Changed the welcome text
Added soething nice ;)
Installed the packages 
Updated the installed packages with the necessary versions 
Committed code to git 

11:27 
Starting with the datbase 
Created a new file in the data folder 
FILE NAME: HairTiesContext.cs 
Added a database context in the public class 
Tried testing the code ...
Everything's good ..No errors at this stage 
Applied migration 
Registered my email id and created a passwrod 

11:40 
Registered the database in startup.cs file with the help of the prived code 
Right after that....
Added the given code to appsettings.json file to examine database 
Builded the app ..
No errors or warnings so far...
Ready to scaffold the application 
But... Before that committing everything to git hub so that my code stays safe !!! 
Scareedd!!!!!
Scafold is a big sucesss without any errors!!!!!
Got all the files in the views folder created after scafolding. 
 Can Drink water now !!!! LOL !!
 Committed code to git hub .....With out any errors till now!!!! ;)

 Its...MIDNIGHT 12:00 
 Starting with the migration 
 Hope it goes right this time!!!! 
 Super scared!!!!
 and wooohhoooooo!!!!!!!!!!!
 No errors migration done !!!!!!
 Superr happyy!!! owuld hug someone tightly...LOL!!
 Completed migration at 12:03 

 Taking a break .... 

 So Back from the break... its 12:06 
 Updated Database ... 
 Got the following syntax error 
 ////  No type was specified for the decimal column 'Price' on entity type 'HairTies'.
 This will cause values to be silently truncated if they do not fit in the default precision and scale. 
 Explicitly specify the SQL server column type that can accommodate all the values using 'HasColumnType()'.//// 
 Trying to solve the error 
 Tried commenting out the price section and running the update database command but build failed 
 Searched the error on Mr.Google...It sayas to specify the value for the decimal datatype 
 But If I specify the decimal type like "decimal(10,5)" my output pannel shows arround 15 syntax errors 
 Trying to solve this error....

 ///@System.Globalization.CultureInfo.CurrentUICulture///
 Added the above mentioned globalization code to the index.htmlcs file 
///app.UseRequestLocalization("en-UY", "fr-FR");///
Added the above mentioned code to the startup.cs file 
Adding this code doesn't help at all 
Ending today's application building here
Committing everything till here to git 
End Time : 1:23 AM 


Date: 16-10-22 4:55pm 
Solved the decimal thing , tested the app and everything works properly 
Edited layout.cshtml file
Replaced "Home" with the "HairTies" on line 14 
Added the about us page in views > home > AboutUs.cshtml 
Added the necessary code 
Edited the layout.cshtml file and homecontroller file with the provided code 
Updated readme and commited code to github 