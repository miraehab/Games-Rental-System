# Games Rental System
This is our project for the Introduction to Database Systems course taken during fall 2022 semester.</br>
A Game rental Software Application using <b>C# programming language</b>

<h2>Description: </h2>
A game rental system provides an easy and cost-effective way to try out new games without having to buy every one.</br></br>
Game rental is a risk-free way to try new games . Because it's so much cheaper than buying.</br></br>
Each game has a vendor who has the responsibility of developing the game.</br></br>
The admin of the system is responsible for adding the games to be rented out by the clients. </br></br>
<b>A games rental system should include the following functionalities : </b></br>
- Signing up a new user ( e.g. admin , client ) </br>
- Updating a user details </br>
- Adding a game ( by admin ) </br>
- Updating a game details ( by admin ) </br>
- Browsing games Showing a list of games that satisfy certain criteria ( e.g. year , vendor , category ... ) </br>
- Performing operations on games : renting , returning .

<h2>Project Steps</h2>
<h3>First: </h3>
We draw the ERD for this project using <b>PowerDesigner</b></br>
Here is the link of the --> <a href="https://github.com/Michael-M-aher/Games-Rental-System/tree/main/ERD">ERD</a></br>

<h3>Second: </h3>
We converted the ERD to physical model (DDL scripts)</br>
Here is the link of the --> <a href="https://github.com/Michael-M-aher/Games-Rental-System/blob/main/Database%20Script/Game-Over.sql">SQL Script</a></br>

<h3>Third: </h3>

We developped the software application using C# and connected the database to be able to perform all the application functions like: sign-in, add game, update game and browse all games that are stored in our database.

<h2>Some screenshots: </h2>

![image](https://user-images.githubusercontent.com/74511706/171738818-2da87538-889b-42d0-b83f-55c12821235b.png)

![image](https://user-images.githubusercontent.com/25803558/171791668-c739787c-4966-4faa-877a-1e98954d8286.png)

![image](https://user-images.githubusercontent.com/25803558/171791667-6a7caa99-20ca-4184-94a7-5f1ed0186ff0.png)

![image](https://user-images.githubusercontent.com/25803558/171775152-9eaf75cd-def4-455d-b0b7-9c4ab0e8c2ae.png)

![image](https://user-images.githubusercontent.com/25803558/171792041-4e6f7337-36e7-4a71-a0a3-d3ab4ca83648.png)</br></br>

Setting up the environment 🛠
--------------------------

#### 1. Create a database in Microsoft SQL Server and name it 'Game-Over'.

#### 2. Open the SQL Script and execute all the Queries in Game-Over database.

#### 3. Open the Solution file and change the 'Data Source' value in the _sqlcon string in "sqlCon.cs" file to the name of your server.

```
internal class sqlCon
    {
        static string _sqlcon = @"Data Source=SeverName; Initial Catalog=Game-Over; Integrated Security=True";
        public static string sqlcon
        {
            get => _sqlcon;
        }
    }
```

#### 3. You have successfully created the database and linked it to the C# Code.</br></br>

<b>To Run the Program here is the default user name and password:</b></br>
username: michael</br>
password: michael1234

