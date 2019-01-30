# DevAcademy  - E-commerce Website Project

![Picture of the Homepage of the website](https://i.imgur.com/qOeH6D9.png)

## Project Information
This is an e-commerce website that I created during my 6-week course at DevAcademy. The project incorporates the use of the following languages and technologies:
* HTML
* CSS
* C#
* Entity Framework 
* ASP.NET Core
* MVC
* Razor Pages 
* SQL Database

I also created the front end of the website using Angular, however Angular has not being integrated into this version of the project. You can view the Angular version of the website by visiting here: 
https://stackblitz.com/edit/e-commerce-website-project

![Picture of the Products page of the website](https://i.imgur.com/SGu6Tt4.png)
## Front End
I had initially created the front end just using HTML and CSS, however due to time constrains I decided to use Bootstrap in conjunction with a pre-created Bootstrap template. However, I felt the visuals of the bootstrap template were a bit plain, so I decided to override many of the CSS properties to help the website feel more colourful and customised. I did experience some minor issues moving to Bootstrap as some of the visuals didn’t look the same as before I started using it, but after some minor tweaks and I managed to get the website looking the way I wanted it to. 
Once that was done, I transitioned into using Angular with the pages created. Whilst Angular took a bit of getting used to at first, I found it to be cool and interesting framework to use. I can certainly see the benefits to using it, particularly when it comes to performance. Angular will be a framework to consider in my future projects.

## Database Creation & Seeding
I created the database using the code-first approach, which gave me the ability to create tables using C# and Entity Framework. In the past, I’ve always used the database-first approach, so it was interesting to see how this method works.
After the database was created, I seeded the database by importing data from a JSON file containing the product information such as product name, categories, prices, etc as well as path for where the product’s image is being stored.

## Authentication
The website also has account authentication, requiring a username or password to log into the website.  I used the authentication system that ASP.NET core provides to do this.

## Project Review
In conclusion, I feel I have accomplished what I wanted to get out of this project – create a website and database, display product information from the database to the website, and add login authentication functionality, However, there is still much more I wish to explore such as changing the front end to use my Angular implementation, as well as setting up a mail server for account registration. All in all, I’m left very satisfied with the outcome of the project, with this being the first time I’ve used many of these various frameworks and languages.
