## Your Name:

# CIDM 3312 Homework 4 - Entity Framework Core
For this homework, you will build a console based application that will store product information for ThoughtTronix in a SQLite database. Your app should also be interactive, allowing the user to add new products, list products, update existing products, and remove products.

## Requirements
1. Start by cloning this assignment repository into VS Code.
2. The app should be a console app with Entity Framework Core using a SQLite database.
3. Create a data model with a Product entity class and database context.
4. The Product entity class should store a ProductID, Name, Description, and Price.
5. Perform migrations to create the database.
6. The following products should be created and added to the database at the start:
   | Name        | Description               | Price             |
   | ----------- | ------------------------- | ----------------- |
   | MindSync    | Neural Implant Device     | $1,995.99         |
   | Seraphine   | AI Assistant              | $200.00           |
   | SoulSear    | Military Grade Death Ray  | $4,300,000,000.00 |
   | PhantomClaw | High Quality Gaming Mouse | $99.95            |
7. Create a console based interactive menu where the user can add, list, update, or remove products from the database. Ensure this menu loops until the user decides to exit the app.
8. User should be able to **add** a new product to the database. Prompt the user to enter the Name, Description, and Price. Store the new product in the database.
9. User should be able to **list** all products. Create a ToString() method inside the Product entity class to support this functionality.
10. User should be able to **update** an existing product. Prompt the user to enter a product ID. Find that product in the database. Allow the user to update the product name, description, and price. Save the changes to the database.
11. User should be able to **remove** a product from the database. Prompt the user to enter the product ID. Find that product in the database. **Ask the user to confirm deletion** and then remove the product.
12. Use db.Database.EnsureDeleted() and db.Database.EnsureCreated() to delete and recreate the database each time your app runs.
13. You can format the interactive console menu however you like. Here is a screenshot of mine to base yours off of (https://i.imgur.com/HJbxRKX.png) -

![HW4_Menu](https://i.imgur.com/HJbxRKX.png)

## Validating User Input
1. User the null-forgiving (`!`) operator with Console.ReadLine() to resolve null warnings.
2. During **update** and **remove**, validate that the user enters a correct product id. If user enters an incorrect id, tell them the product is not found.
3. **Extra Credit** Validate that the user enters a correct decimal price. If user enters an invalid price prompt them again. Use a try/catch block to catch invalid input here and decimal.Parse().

## Submit your assignment
1. Save your program and run it. At the terminal prompt, type `dotnet run`.
2. Edit `README.md` and put your name at the top.
3. Push your changes to GitHub:
    - Click the source control icon in VS Code
    - Type in a commit message
    - Click the checkbox icon to commit. (Click yes on the message box to stage your commit)
    - Click the 3 dots icon (...) for more actions and click Push.
4. Or you can push your changes to GitHub using the Terminal:
    ```
    git add -A
    git commit -m "Your commit message"
    git push
    git status
    ```
5. Verify that your changes are on GitHub.
6. Congratulations! Your assignment is complete.
