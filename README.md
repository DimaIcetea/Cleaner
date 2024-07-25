# Cleaner

# Cleaner

Cleaner is a WPF application that provides various functionalities to clean temporary files, log files, DNS cache, and more. It also includes features to open system tools like the Windows Registry Editor and MSConfig with elevated privileges.

## Features

- Clean Temporary Files
- Clean Log Files
- Clean DNS Cache
- Open Windows Registry Editor
- Open MSConfig
- Open a custom registry editor window

## Prerequisites

- .NET Framework 4.7.2 or higher
- Windows Operating System

## Getting Started

### Cloning the Repository

To get started with the project, clone the repository using the following command:

```bash
git clone https://github.com/yourusername/Cleaner.git
```
## Setting Up the Project
· Open the solution file (Cleaner.sln) in Visual Studio.
· Add the .cmd and .reg files to the project:
· Right-click the project in Solution Explorer.
· Select Add > Existing Item....
· Choose the necessary files and add them to the project.
  Configure the properties of these files:
· Set Build Action to Content.
· Set Copy to Output Directory to Copy if newer or Copy always.
· Building and Running the Project
· Build the project by clicking Build > Build Solution.
· Run the project by clicking Debug > Start Debugging or pressing F5.

## Contributing
Contributions are welcome! Please follow these steps:

· Fork the repository.
· Create a new branch (git checkout -b feature/YourFeature).
· Commit your changes (git commit -m 'Add some feature').
· Push to the branch (git push origin feature/YourFeature).
· Open a Pull Request.
