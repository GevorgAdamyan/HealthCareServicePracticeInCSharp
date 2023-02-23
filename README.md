# Selenium + C# Practice

This repository contains examples of Selenium tests written in C# language, NUnit framework and Page Object Model. 

## Requirements

- .NET Core

## Installation

1. Clone the repository
2. Install .NET Core (This project is written using version 7.0)
3. Install dependencies using:
    ```
    dotnet restore
    ``` 

## Usage

1. Navigate to the root folder of the project
2. Run the tests using the following command:
    ```
    dotnet test
    ```

## Contents

### Pages namespace

The classes in `Pages` namespace contain fields and methods which describe the pages for Page Object Model pattern.

### Support namespace

The classes in `Support` namespace contain useful methods and data that can be used in Selenium tests.

#### Utils class

The `Utils` class contains useful methods that can be used in Selenium tests.

##### Methods

- `GenerateRandomNumber(int min, int max, bool maxInclusive)` - Generates a random integer between the specified minimum and maximum values. Use boolean      values to include or exclude the "max".
- `GenerateRandomBoolean()` - Generates a random boolean value (true or false).
- `GetCurrentDate()` - returns the current date.
- `GenerateRandomText()` - Generates random lorem paragraph using "Faker".

#### Assertions class

The `Assertions` class contains assert methods which looks more readable.

##### Methods

- `AssertElementVisibility(IWebElement element)` - verifies, is the specified element displayed.
- `AssertPageUrl(IWebDriver driver, string path)` - verifies, does the current page url contains specified path.
- `AssertElementText(IWebElement element, string text)` - verifies, does the specified element contains specified text.

#### Data class

The `Data` class contains different data which is useed in tests.

### Test classes

The test classes are located in the `Tests` folder and contain examples of Selenium tests written in C# language.

## Contributing

Contributions are welcome! If you would like to contribute to this repository, please fork the repository and submit a pull request.

## License

This repository is licensed under the [MIT License](https://opensource.org/licenses/MIT).
