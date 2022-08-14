# 🔒 C# Implementation of CRC algorithm

## Introduction
- This program calculates the CRC-16 or CRC-32 code of the message entered by the user.
- Outputs are given to the user according to all CRC-16 and CRC-32 types.
- This is program was written in [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) using [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
- This program was written in [.NET Framework 4.6](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net46) (If you want to run this application please be sure that you have [.NET Framework 4.6](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net46))
- [Windows forms](https://docs.microsoft.com/en-us/dotnet/desktop/winforms/overview/?view=netdesktop-6.0) were used for the Frontend App.
## Explanation of the program
- This application is an application that makes CRC-16 and CRC-32 encryption.
- It has two different screens. The first screen is called the Start Screen.cs and there are buttons where you can start the application or exit the application directly.
- With the "Encode" button, the application starts and a screen appears in front of the user. The user can input in two different ways:
  - **HEX**:
  ```bash
  EX: "31 32 33 34 35 36 37 38 39" or "313233343536373839"
  ```
  - **ASCII**:
  ```bash
  EX: "123456789" or "this is a test"
  ```
  - When the user enters an input, he/she should click on the Combo box on the right and indicate that he is giving an input in HEX or ASCII.
- Input from the user is converted to a byte array and sent to the CRC algorithm.
- At the same time, the user can select two different algorithms for both CRC-16 and CRC-32:
  ### Crc16.cs and Crc32.cs
  - These two classes basically do the same job in different ways. Both have the same algorithms. Only CRC-16 processes 16-bit data respectively, while CRC-32 processes 32-bit data. Both classes have both the "Original CRC calculation" method and the "Calculation with Lookup Table" method.
  ### StartScreen.cs
  - This screen is the home screen of the application.
  
  ![image](https://user-images.githubusercontent.com/75734949/184542274-19db984c-2513-47d7-856c-500ba001445a.png)
  ### Form1.cs
  - As seen in the picture, there is a part where input is taken from the user. However, there are CRC-16 and CRC-32 buttons.
  - The user can calculate the CRC code according to the type of algorithm he/she wants.
  - The user must specify which type of input he/she is entering.
  
  ![image](https://user-images.githubusercontent.com/75734949/184542500-53af4c2c-73e5-4b41-9374-04701292fc24.png)
  
  - An example of the application is as in the image below:
  
  ![image](https://user-images.githubusercontent.com/75734949/184542441-3d86b449-15fc-47a3-8e95-d55acc319d7f.png)

## References
- [CRC Error Detection Algorithms](https://zlib.net/crc_v3.txt)
- [Catalogue of parametrised CRC algorithms](https://reveng.sourceforge.io/crc-catalogue/)

  
