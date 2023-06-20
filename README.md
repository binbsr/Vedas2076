# Vedas Lab Work - NET Centric Computing
## Your lab sheet should contain solutions for all questions below.

## A. Short programs  
1. Check if user says "Hi" or "Hello"?
1. Largest number among 3 numbers?
1. Check if entered alphabet is vowel or not?
1. Check if entered number is even or not (use ternary operator)?
1. Calculate the sum of squares of first *n* natural numbers.
1. Write C# method that calculate average of 3 decimal number arguments.
1. Modify same method above that allows user to supply any number of argumnets and calculate average of all.
1. Wrtie C# method that count total males, females and others, given the array of genders as:
```csharp
char?[] genderCollection = new char?[] { 'F', 'M', 'F', 'M', null, 'M', null, 'F', 'F', 'M', null, null, 'F', 'M', 'M' };
```

## B. Create class named `*Collection*`, create 3 methods in there: 
1. `GetAnimals()` which returns list of animal names. 
2. `FetchSongs()` which returns list of songs (song name and genre).
3. Modify (2) to return list of songs (name, genre and artist name).

Call all three methods from `Main()` and print results to console.

## C. Think of a real-world class within a proper namespace which should have:
1. Default and parameterized constructor
1. Two auto-implemented properties
1. A read-only property evaluated from other properties
1. A write-only property
1. A constant that can be changed at compile time
1. A constant that runtime instances can modify
1. An enumeraiton list within that namespace that this class genuinely need
1. A method that returns value of two properties of point 2


## D. Think of a real world scenario for following class design:
    
        TypeB inherits TypeA
        TypeB implements InterfaceA
    
  1. Note that **TypeA** should have at least two methods, two fields and two properties.
  1. Create instance of **TypeB**, show output of those methods in console.

## E. Create an dictionary collection containing at least 20 country names and their population. Query this collection to answer following:
    1. List all countries starting with letter N.
    1. List all countries with population less than 2M.
    1. Find total population of 20 countries.

## F. Generate a text file (Physically) with content copied from [The Aduenture of Black Peter](http://textfiles.com/stories/blackp.txt). Read the file content in your program and print following to console:
1. Number of characters
1. Number of words
1. Number of sentences
1. Number of vowels
1. Number of special characters


## G. MovieManager Web Portal
### Movie Mangaer have three related models to deal with:
`Movie` (ID, Title, Rating, Budget, Gross, Release Date, Genre, Runtime, Summary)

`Actor`(ID, Name, Date of Birth, Birth City, Birth Country, Height (Inches), Biography, Gender, NetWorth)

`Charactor`(MovieID, ActorID, Character Name, Pay, Screentime)

### This app should have following features:
* Add new movies to database
* Add new actors to database
* Add new and update existing characters on database
* Dashboard page showing:
  * List of top 10 flop movies
  * List of top 5 highest paid actors and role they played

### Requirements
  1. `ASP.NET Core 7.0+`
  1. Please use `SQLite` as your database
  1. Plain `ADO.NET` or any ORM tools for data access
