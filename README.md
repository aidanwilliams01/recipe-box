# Recipe Box

#### By Aidan Williams

## Technologies Used

* _C#_
* _.NET_

## Description

A website where users can keep track of their recipes.

## Setup Instructions

1. Clone this repo.
2. Navigate to this project's production directory.
    1. Create a file called "appsettings.json"
    2. Add the following code to the file (username and password credentials are for your local server):
    
        `{
          "ConnectionStrings": {
            "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR-DATABASE-NAME];uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
          }
        }`
3. Open your terminal (e.g., Terminal or GitBash) and navigate to this project's production directory.
4. Run `dotnet ef database update` in the command line.
5. Run `dotnet run` in the command line.
6. Visit https://localhost:5001/ in your web browser.
7. Optionally, you can run `dotnet build` to compile this website without running a local server.

## Known Bugs

* _No known bugs._

## License

_[GPL](https://en.wikipedia.org/wiki/GNU_General_Public_License)_

Copyright (c) _2023_ _Aidan Williams_