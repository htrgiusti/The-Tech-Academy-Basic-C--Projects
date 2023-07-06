# Car Insurance Project
This is a C# ASP.NET MVC Entity Framework project from The Tech Academy bootcamp. 

This project is an MVC web application that mimics a car insurance website. It takes user's input
on policy information and calculates a quote based on business logic. There is also an admin 
page that allows staff to view all of the quotes that have been issued.

**In this project I had to complete these actions:**

1. **In the InsureeController, add logic to calculate a quote based on these guidelines:**

**a.** Start with a base of $50 / month.

**b.** If the user is 18 or under, add $100 to the monthly total.

**c.** If the user is from 19 to 25, add $50 to the monthly total.

**d.** If the user is 26 or older, add $25 to the monthly total. Double check your code to ensure all ages are covered.

**e.** If the car's year is before 2000, add $25 to the monthly total.

**f.** If the car's year is after 2015, add $25 to the monthly total.

**g.** If the car's Make is a Porsche, add $25 to the price.

**h.** If the car's Make is a Porsche and its model is a 911 Carrera, add an additional $25 to the price. (Meaning, this specific car will add a total of $50 to the price.)

**i.** Add $10 to the monthly total for every speeding ticket the user has.

**j.** If the user has ever had a DUI, add 25% to the total.

**k.** If it's full coverage, add 50% to the total.

2. **Modify the Create View so that the user does not see the “Quote” input field.**

3. **Add an Admin View for a site administrator to the Insuree Views. This page must show all quotes issued, along with the user's first name, last name, and email address.**
