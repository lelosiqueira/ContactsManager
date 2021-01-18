# ContactsManager

This is a C# .net Core web app to manage contacts made by Leandro Pires Siqueira. It contains registration, listing, visualization and deletion of Contacts, which may
be either a Natural person or Legal person.


## Installation

Packages:

Microsoft.AspNet.Mvc

Microsoft.AspNet.WebApi.Core

Microsoft.VisualStudio.Web.CodeGeneration.Design

```bash
Make sure you have Visual Studio 2017 or greater. Open ContactsManager.sln and run it.
```

## Usage


On menu, you have Natural Person and Legal Person.

##### Natural Person 

listing

registration ("create new" button)

visualization ("details" button)

deletion ("delete" button)

##### Legal Person 

listing

registration ("create new" button)

visualization ("details" button)

deletion ("delete" button)




## Choices
I choose to separate Natural and Legal person. I think they may have different business rules, so i prefer to treat them as distinct objects.

I have used HttpContext.Session to store Lists, so you can replace all the methods in NP.cs and LP.cs with database methods.


## To Do

1. Put masks on CPF and CNPJ textbox
2. Create ID instead of using CPF and CNPJ as primary keys
3. Show warning when deleting contacts

## License
[MIT](https://choosealicense.com/licenses/mit/)