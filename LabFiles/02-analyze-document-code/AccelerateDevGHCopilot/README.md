# Library App

## Description
Library App is a .NET console application for managing library patrons, book loans, and memberships. It provides an interactive experience for searching patrons, viewing loan details, renewing memberships, extending due dates, and marking loans as returned.

## Project Structure
- src/
  - Library.ApplicationCore/
    - Entities/
    - Enums/
    - Interfaces/
    - Services/
  - Library.Console/
    - Json/
  - Library.Infrastructure/
    - Data/
- tests/
  - UnitTests/
    - ApplicationCore/
      - LoanService/
      - PatronService/

## Key Classes and Interfaces
- Library.ApplicationCore.Entities
  - Author
  - Book
  - BookItem
  - Loan
  - Patron
- Library.ApplicationCore.Services
  - LoanService: handles loan return and extension workflows
  - PatronService: handles membership renewal rules
- Library.Console
  - ConsoleApp: drives the interactive console experience
- Library.Infrastructure.Data
  - JsonData: loads and saves data from JSON files
- Interfaces
  - ILoanService
  - IPatronService
  - ILoanRepository
  - IPatronRepository

## Usage
1. Restore dependencies and build the project:
   - dotnet build
2. Run the console application:
   - dotnet run --project src/Library.Console/Library.Console.csproj
3. Follow the prompts to search for patrons, review loans, and manage membership actions.

## License
This project is provided for educational purposes. If you plan to distribute or reuse it beyond the classroom environment, add an appropriate license file that matches your intended usage.