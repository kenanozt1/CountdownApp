# CountdownApp

CountdownApp is a desktop application that allows users to manage hour, minute, and second information. The application aims to simplify time management with its user-friendly interface and SQLite database integration.

## Features

- Time input in hour:minute:second format
- Automatic completion of missing time units (with 00)
- Persistent data storage in SQLite database
- User-friendly visual interface
- Easy data entry with MaskedTextBox and DateTimePicker controls

## Requirements

- .NET Framework 4.7.2 or higher
- SQLite database
- Visual Studio 2019 or higher (for development)

## Installation

1. Clone the project:
```bash
git clone https://github.com/username/CountdownApp.git
```

2. Open the project with Visual Studio
3. Install required NuGet packages:
   - System.Data.SQLite
   - System.Data.SQLite.Core

4. Build and run the project

## Usage

1. Start the application
2. Enter time information:
   - HH:MM:ss (Hours:Minutes:Seconds)
3. Click the "Save" button to save your entered time
4. View saved times in the list

## Database Structure

The application uses SQLite database. The database schema is as follows:

```sql
CREATE TABLE time (
    ID INTEGER PRIMARY KEY AUTOINCREMENT,
    date TEXT,
    time TEXT,
);
```

## Contributing

1. Fork this repository
2. Create a new branch (`git checkout -b feature/newFeature`)
3. Commit your changes (`git commit -am 'Added new feature'`)
4. Push your branch (`git push origin feature/newFeature`)
5. Create a Pull Request

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.