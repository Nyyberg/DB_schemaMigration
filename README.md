# How to add a migration
----------------------
## 1. add your connection string to the OnConfiguration method on line 21 like so:

Example:
> protected override void OnConfiguring(DbContextOptionsBuilder options)
>    => options.UseSqlServer("YOUR;CONNECTION;STRING");


## 2. Start with adding a model to the models.cs file like so

Example:
> public class Products {
> public int ID {get; set;}
> public string ProductName {get; set;}
> }

## 3. Add the model to the dbSet to the top like so

Example:
> public DbSet<Products> Product { get; set; }

## 4. in your terminal of choice make your way to the project folder and write the command like so

Example:
> dotnet ef migrations "your-name"

## 5. then again in your terminal of choice write like so:
> dotnet ef database update


# How to remove a Migration
------------------------

## 1. first you want to get a list of migrations, in your terminal of choice make your way to the project folder and write the command like so

>dotnet ef migrations list

## 2. when you have identified the migration you want to remove, again in the terminal write the followling command

>dotnet ef database update "your-migration-name"

### if you would like to remove all in one go, the command is
>dotnet ef database update 0

### or if you want to remove last migration added the command is
>dotnet ef migrations remove
