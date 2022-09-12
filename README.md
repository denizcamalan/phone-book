# phone-book

Console Phonebook Application

Open a new console application and write a phone book application. The features that should be in the application are as follows.


Register Phone Number
Delete Phone Number
Update Phone Number
Directory Listing (A-Z, Z-A optional)
Search in the Directory

Explanation:

As a start, add the number of 5 people by default.

When the application first starts, the user is selected for the action he wants to do.

  Please select the action you want to do :)
  *******************************************
  (1) Registering a New Number
  (2) Deleting Existing Number
  (3) Updating Existing Number
  (4) Listing the Directory
  (5) Searching the Directory﻿

(1) Registering a New Number

 Please enter name :
 Please enter your surname:
 Please enter phone number:

(2) Deleting Existing Number

It is sufficient to search by name and surname.

  Please enter the name or surname of the person whose number you want to delete:

If a person cannot be found in the directory based on the input from the user:

  The data matching your search criteria could not be found in the directory. Please make a selection.
  * To terminate the deletion: (1)
  * To try again : (2)

If appropriate data is found in the directory:

  {} is about to be deleted from the directory, do you confirm?(y/n)
Note: If there is more than one person who meets the appropriate criteria in the directory, the first found should be deleted.


(3) Updating Existing Number


 Please enter the name or surname of the person whose number you want to delete:


If a person cannot be found in the directory based on the input from the user:



 The data matching your search criteria could not be found in the directory. Please make a selection.
 * To terminate the update: (1)
 * To try again : (2)


If appropriate data is found in the directory, the update is performed.

Note: If there is more than one person who meets the appropriate criteria in the directory, the first found should be deleted.

(4) Listing the Directory

All contacts are listed to console in the following format.

  Telephone directory
  **********************************************
  name: {}
  Last name: {}
  Phone number: {}
  -
  name: {}
  Last name: {}
  Phone number: {}
  .
  .


(5) Searching the Directory


 Select the type you want to search.
 **********************************************
 
 To search by first or last name: (1)
 To search by phone number: (2)


The data found according to the search result should be displayed in the following format.


 Your Search Results:
 **********************************************
 name: {}
 Last name: {}
 Phone number: {}
 -
 name: {}
 Last name: {}
 Phone number: {}
 .
 .


** Each feature must be made using a separate class/method. As much as possible their responsibilities should be fragmented and the code should be readable.