## Summary
MVC Web Application that reads in a csv file with Time Persons of the Years from 1927-2017 and allows users to see outputs of only targeted year ranges.  

Outputs include such information as First/Last Name, Context for why they won the award, Birth/Death Year.

## Output
![home page](https://github.com/KKetter/LAB11-Time-Person-of-the-Year/tree/master/LAB11-TIMEPERSONOFTHEYEAR/assets/index-page.jpg)

![results page](https://github.com/KKetter/LAB11-Time-Person-of-the-Year/tree/master/LAB11-TIMEPERSONOFTHEYEAR/assets/results-page.jpg)

## Common Usage
1) User Inputs a year range, 4 digit year format, with starting year being less than ending year and submits.
2) Redirected to results page where a list of filtered results is displayed.
3) This page provides detailed output by year showing all awardees within provided ranges - some fields are blank as the imported data had intentional gaps - ie death date of "The American Solider"
4) Missing integer values intentionally return a 0

## Other Relevant Details
If the user inputs a year range where ending year < starting year then all information will be displayed
If a numerical value does not exist from the csv a "0" will be populated in the field
Any string values not existing are leave the box blank