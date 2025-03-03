# Dynamics365WorkflowActivities

A collection of custom workflow activities for Microsoft Dynamics 365.

## Overview

This repository contains custom workflow activities that extend the functionality of Microsoft Dynamics 365. These activities can be used in Dynamics 365 workflows to automate business processes beyond what's available out-of-the-box.

## Included Activities

The repository includes the following custom workflow activities:

1. **CreateEmailFromTemplate** - Creates an email from a specified template with enhanced capabilities.
2. **SendEmailInternational** - Provides international email sending capabilities for Dynamics 365.

## Getting Started

### Prerequisites

- Microsoft Dynamics 365
- Visual Studio
- .NET Framework compatible with your Dynamics 365 version

### Installation

1. Clone the repository:
   ```
   git clone https://github.com/LukaAsceric/Dynamics365WorkflowActivities.git
   ```

2. Open the solution file `Dynamics365WorkflowActivities.sln` in Visual Studio.

3. Build the solution.

4. Register the assembly in your Dynamics 365 environment using the Plugin Registration Tool.

## Usage

After registering the assembly, the custom workflow activities will be available in the Dynamics 365 workflow editor. You can use them like any other workflow activity.

## Project Structure

- `CreateEmailFromTemplate.cs` - Implementation of the email template workflow activity
- `SendEmailInternational.cs` - Implementation of the international email sending activity
- `model/` - Contains model classes used by the activities
- `Properties/` - Project properties

## License

This project is licensed under the GPL-3.0 License - see the [LICENSE.txt](LICENSE.txt) file for details.

## Contributing

Contributions are welcome. Please feel free to submit a Pull Request.

## Support

For questions and support, please open an issue in the GitHub repository.
