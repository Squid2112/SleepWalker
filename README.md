# SleepWalker

SleepWalker is a lightweight Windows application that allows you to control your computer's sleep behavior easily from the system tray. With SleepWalker, you can prevent your computer from entering sleep mode or re-enable sleep mode with just a few clicks.

![SleepWalker Icon](https://github.com/Squid2112/SleepWalker/blob/main/SleepWalker.png)

## Table of Contents

- [Features](#features)
- [Installation](#installation)
- [Usage](#usage)
- [Building from Source](#building-from-source)
- [How It Works](#how-it-works)
- [Requirements](#requirements)
- [Contributing](#contributing)
- [License](#license)
- [Acknowledgments](#acknowledgments)

## Features

- **Prevent Sleep Mode**: Stops the computer from entering sleep mode.
- **Enable Sleep Mode**: Allows the computer to sleep as per system settings.
- **System Tray Application**: Runs quietly in the background with an icon in the system tray.
- **Easy Access**: Quickly access all features through the context menu.
- **Lightweight**: Minimal resource usage.

## Installation

1. **Download the Latest Release**:

   - Visit the [Releases](https://github.com/Squid2112/SleepWalker/releases) page.
   - Download the `SleepWalker.exe` file.

2. **Run the Application**:

   - Double-click the downloaded `SleepWalker.exe` to start the application.
   - SleepWalker will minimize to the system tray.

## Usage

1. **Accessing the Menu**:

   - Locate the SleepWalker icon in the system tray.
   - Right-click the icon to open the context menu.

2. **Prevent Sleep Mode**:

   - Click on **Prevent Sleep**.
   - A notification will appear confirming that sleep mode is disabled.

3. **Enable Sleep Mode**:

   - Click on **Enable Sleep**.
   - A notification will appear confirming that sleep mode is enabled.

4. **Exit Application**:

   - Click on **Exit** to close SleepWalker.

## Building from Source

If you wish to build SleepWalker from source, follow these steps:

1. **Clone the Repository**:

   ```bash
   git clone https://github.com/yourusername/SleepWalker.git
   ```

2. Open the Solution in Visual Studio:

   - Navigate to the project directory.
   - Open SleepWalker.sln with Visual Studio 2022 or later.

3. Restore NuGet Packages:

   - Visual Studio should automatically restore any necessary packages.

4. Build the Solution:

   - Go to Build > Build Solution or press Ctrl + Shift + B.

5. Run the Application:

   - Press F5 to run the application in Debug mode.
  

## How It Works

SleepWalker uses the Windows API function SetThreadExecutionState to control the system's sleep behavior.

   - Prevent Sleep: Calls SetThreadExecutionState with ES_CONTINUOUS | ES_SYSTEM_REQUIRED flags to prevent sleep.
   - Enable Sleep: Calls SetThreadExecutionState with ES_CONTINUOUS flag to restore default behavior.

## Key Components

   - Form1.cs: Contains the main logic and event handlers.
   - Form1.Designer.cs: Contains the designer-generated code for UI components.
   - NotifyIcon: Represents the icon in the system tray.
   - ContextMenuStrip: Provides the context menu for the system tray icon.

## Requirements

   - Operating System: Windows 7 or later
   - .NET Framework: .NET 6.0 or higher
   - Development Environment (for building from source):
      - Visual Studio 2022 or later
      - .NET Desktop Development workload installed

## Contributing

Contributions are welcome! Please follow these steps:

1. Fork the Repository:

   - Click on Fork at the top right corner of the repository page.

2. Create a Feature Branch:
   ```bash
   git checkout -b feature/YourFeature
   ```

3. Commit Your Changes:
   ```bash
   git commit -am 'Add new feature'
   ```

4. Push to the Branch:
   ```bash
   git push origin feature/YourFeature
   ```

5. Open a Pull Request:

   - Navigate to your forked repository.
   - Click on New Pull Request.

## License

This project is licensed under MIT License.

## Acknowledgments

   - Icons8: For providing free icons used in the application.
   - Microsoft Documentation: For guidance on using Windows API functions.
