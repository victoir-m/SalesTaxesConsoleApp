# SalesTaxesConsoleApp

Console App ReadMe

Problem Statement: Sales Taxes

Basic tax is applicable at a rate of 10% on all goods, except books, food, and medical products that are
exempt. Import duty is an additional tax applicable on all imported goods at a rate of 5%, with no exceptions.
When I purchase items I receive a receipt which lists the name of all the items and their price (including tax),
finishing with the total cost of items, and the total amount of tax paid.

The rounding rules for tax are:
For a tax rate of n%, a shelf price of p contains (np / 100 rounded up to the nearest 0.05) amount of
tax.

Required
- Visual Studio 2022
- Target frame work net 8.0

Installed Packages 
- AutoMapper 13.0.1
- Newtonsoft.Json 13.0.3

The data is stored in a Json file located in the following folder net8.0, the path has been provided below
"SalesTaxesConsoleApp\SalesTaxesConsoleApp\bin\Debug\net8.0\Items.json"

Steps 
- Upon cloning or unzipping the application, open it in visual studio 
	- Right click on the Solution and Restore NuGet packages 
	- Rebuild the Application 
	- Run the application by clicking on the play button with the name SalesTaxesConsoleApp

Below is an example of the application as it is running and produces expected results

Item Id Item Name                       Price           Imported Item   Taxable Item
1       Book                            12.49
2       Music CD                        14.99                               Yes
3       Chocolate Bar                    0.85
4       Box of Chocolates               10.00          Imported
5       Bottle of Perfume               47.50          Imported             Yes
6       Bottle of Perfume               27.99          Imported             Yes
7       Bottle of Perfume               18.99                               Yes
8       Packet Paracetamol               9.75
9       Box of Chocolates               11.25          Imported


Please enter the Item ID as indicated above (or type 0 to checkout and -1 to stop the application) :
1
Enter quantity:
1
Please enter the Item ID as indicated above (or type 0 to checkout and -1 to stop the application) :
2
Enter quantity:
1
Please enter the Item ID as indicated above (or type 0 to checkout and -1 to stop the application) :
3
Enter quantity:
1
Please enter the Item ID as indicated above (or type 0 to checkout and -1 to stop the application) :
0
--------------------------------------------------

Sales Receip:

1 Book: 12.49
1 Music CD: 16.49
1 Chocolate Bar: 0.85

Sales Taxes: 1.50
Sales Total: 29.83

--------------------------------------------------



Would you like to continue shopping? (yes/no)
yes


Item Id Item Name                       Price           Imported Item   Taxable Item
1       Book                            12.49
2       Music CD                        14.99                               Yes
3       Chocolate Bar                    0.85
4       Box of Chocolates               10.00          Imported
5       Bottle of Perfume               47.50          Imported             Yes
6       Bottle of Perfume               27.99          Imported             Yes
7       Bottle of Perfume               18.99                               Yes
8       Packet Paracetamol               9.75
9       Box of Chocolates               11.25          Imported


Please enter the Item ID as indicated above (or type 0 to checkout and -1 to stop the application) :
