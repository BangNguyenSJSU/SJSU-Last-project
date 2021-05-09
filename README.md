# SJSU-Senior Project


<!-- TABLE OF CONTENTS -->
<details open="open">
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#Technology and Resource Requirements"> Technology and Resource Requirements </a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li>
      <a href="#Usage-Example-and-Demo">Usage Example and Demo</a>
      <ul>
        <li><a href="#Hardware-Connection">Prerequisites</a></li>
        <li><a href="#Software-Requirement">Installation</a></li>
        <li><a href="#Running-The-Application-With-Command-Line-Interface-(CLI)">Running-the-application-with-Command-Line-Interface-(CLI)</a></li>
        <li><a href="#Using-the-GUI-button-To-Send-The-Instruction-And-Retrieve-The-Result">Using-the-GUI-button-To-Send-The-Instruction-And-Retrieve-The-Result</a></li>
        <li><a href="#Video-Demo">Video-Demo</a></li>
      </ul>
    </li>
    <li><a href="#Roadmap">Roadmap</a></li>
   
  </ol>
</details>

<!-- ABOUT THE PROJECT -->
## About The Project
Embedded systems have been applied to the sensor, monitor, send, or receive data between them. To make communication most effective between every device, people usually use serial communication. The master starts the conversation by sending data and tasks to the slaves and receiving the slave’s information. Serial communication is used for the chip to chip communication, and it can help the transmission of data between multiple devices be more comfortable and faster. 

We develop a debug tool for serial communication protocol (I2C and SPI) tools for this project. The tool also provides a graphical user interface (GUI). The tool should behave as a Master and read or write on any slave device using I2C or SPI protocol. For example, suppose we have a human body temperature sensor using the I2C protocol. In that case, we can probe the pin from the sensor to our tool and run a quick test on the device based on the slave address and register address provided from the datasheet.

   ![image](https://user-images.githubusercontent.com/38081550/117555671-0b487880-b016-11eb-8311-a51af460b3a4.png)


## Technology and Resource Requirements 
* Hardware Component: 
* * [Maxim Microcontroller MAX32630FTHR ](https://www.maximintegrated.com/en/products/microcontrollers/MAX32630FTHR.html)
* * [Amazon Jumper Cable](https://www.amazon.com/Elegoo-EL-CP-004-Multicolored-Breadboard-arduino/dp/B01EV70C78/ref=asc_df_B01EV70C78/?tag=hyprod-20&linkCode=df0&hvadid=222785939698&hvpos=&hvnetw=g&hvrand=306934414797952629&hvpone=&hvptwo=&hvqmt=&hvdev=c&hvdvcmdl=&hvlocint=&hvlocphy=9032175&hvtargid=pla-362913641420&psc=1)
* * [Slave Device for Testing: I2C→ Human Body Temp Sensor MAX30208](https://www.maximintegrated.com/en/products/sensors/MAX30208EVSYS.html)
* * [Slave Device for Testing: SPI→ VS1053b (SPI) MIDI Audio Codec](https://www.adafruit.com/product/1381?gclid=CjwKCAjw7diEBhB-EiwAskVi15HFjzuNsBJIbKIIrAkVQb-nS-RXtfBMl80TvxRCWkYuI-D4Eh5rLhoCEEwQAvD_BwE)
* Software Component
* * [Mbed OS + Mbed compiler](https://os.mbed.com/)
* * [Visual Studio Community 2019](https://visualstudio.microsoft.com/vs/community/)
* * [Visual Studio Code Editor](https://code.visualstudio.com/)

<!-- GETTING STARTED -->
## Getting Started

This is an example of how you may give instructions on setting up your project locally.
To get a local copy up and running follow these simple example steps.

### Prerequisites

This is an example of how to list things you need to prepare and for the project.

* The MAX32630FTHR board is a rapid development platform designed to help engineers quickly implement battery optimized solutions with the MAX32630 ARM Cortex-M4F microcontroller. The board also includes the MAX14690N Wearable PMIC to provide optimal power conversion and battery management
![Capture](https://user-images.githubusercontent.com/38081550/117555945-9591dc00-b018-11eb-8ff5-6ce1cba58335.PNG)

*  * You need to sign up for a Mbed account. [Link for Mbed Handbook](https://os.mbed.com/docs/mbed-os/v6.10/introduction/index.html)
*  * You need to download and install all packets for Windows Forms App (. NET Framework) in Visual Studio Community 2019. [Visual Studio tutorials | C#](https://docs.microsoft.com/en-us/visualstudio/get-started/csharp/?view=vs-2019)

### Installation

1. After signing up for the Mbed account, you can sign in  in the Mbed OS website.
* Click on this link to access the project repository [Click Here](https://os.mbed.com/users/bangclever/code/SeniorProject_final_ver/) --> Immport it to your workspace account
![tempsnip](https://user-images.githubusercontent.com/38081550/117556166-c115c600-b01a-11eb-9c9d-e890f390c08b.png) 
* Click in the workspace interface click on "compile". Mbed OS will automatically compile then download a .bin file to your computer. 
* The MAX32630FTHR board ships with an external DAPLink adapter such as the MAX32625PICO (Programmable Interface Controller). To flash the firmware ( .bin file ) to MAX32630FTHR, you need:
* * Connect the MAX32630FTHR with MAX32625PICO Programmable Interface Controller.
* * Connect both of them to the PC. Open File Explorer/ This PC. You will see DAPLINK Disk pop up.
* * Simply drag and drop the .bin file, which generate from the Mbed Compiler to the DAPLINK Disk. After that, press reset button on MAX32630FTHR --> you will see the blue LED blinking every one second to indicate the board running.
![Capture3](https://user-images.githubusercontent.com/38081550/117556590-6337ad00-b01f-11eb-9f1d-568cfa85bc3a.PNG)


2. Clone the reposiotry for GUI interface (Required all packets for Windows Forms App (. NET Framework) in Visual Studio Community 2019)
   ```sh
   git clone https://github.com/BangNguyenSJSU/SJSU-Last-project.git
   ```
* Open the Microsoft Studio 2019 Community --> File / Open Folder /..../...Git Folder here
* This is the GUI interace for the project for succesfully open. Click on "Start" button to run the build and run the solution
* ![Capture4](https://user-images.githubusercontent.com/38081550/117556849-186b6480-b022-11eb-93e2-1c55cb7c3fb6.PNG)

<!-- Usage Example and Demo -->
## Usage Example and Demo

The microcontroller SPI or I2C peripheral pin will be connected to the slave device. The READ and WRITE register commands are sent by micro USB connection, which is instructed by the user through PC. The PC will use a serial COM port to communicate with Microcontroller through the UART port. There are two methods that we can use to send the instruction to the microcontroller.	

### Hardwre Connection: 
* CS pin for SPI is GPIO P3_2
![Capture5](https://user-images.githubusercontent.com/38081550/117556982-6df44100-b023-11eb-97f0-86fe46315004.PNG)
### Software requirement:
* You need a Terminal Application.Terminal applications will run on your host PC, and provide a window for your mbed Microcontroller to print to, and a means for you to type characters back to your mbed Microcontroller.
* * You can check here for more alternative Terminal Application. [Click here for more detail](https://os.mbed.com/handbook/Terminals)
* * However, Our GUI also provide a Terminal Emulator for Serial COM Port connection. 

### Running the application with Command Line Interface (CLI):
* READ:​	 
* * **Input**: char ‘I’ to identify I2C protocol or char ‘S’ to identify SPI protocol
* * **Input**: char ‘R’ to perform read
* * **Input**: Slave Address
* * **Input**: RegisterAddress.
* * **Input**: Number of Byte (Default value = 1).
* WRITE:​	 
* * **Input**: char ‘I’ to identify I2C protocol or char ‘S’ to identify SPI protocol
* * **Input**: char ‘W’ to perform write
* * **Input**: SlaveAddress.
* * **Input**: RegisterAddress.
* * **Input**: Value of Byte.
Program display Output through PC serial COM PORT 

#### Running CLI on terminal emulator (Tera Term). Perform I2C READ and WRITE transaction on Slave Address: 0xA0, Register Address: 0x13 Written Value: 0x05.
![i2c](https://user-images.githubusercontent.com/38081550/117557261-f673e100-b025-11eb-94ec-2ef8cbd621e2.png)

#### Running CLI on terminal emulator (Tera Term). Perform SPI READ (OP Code:03)  and WRITE (OP Code: 02) transaction on Register Address: 0x0b Written Value: 0x2525.
![spi](https://user-images.githubusercontent.com/38081550/117557269-0a1f4780-b026-11eb-9de4-c5edd37b308c.png)

#### Our GUI button by C# and run on the window.
* General Interface Outline:
![Capture6](https://user-images.githubusercontent.com/38081550/117557338-9e89aa00-b026-11eb-8837-c4481859a866.PNG)

* Running CLI on our own terminal emulator. Perform I2C READ and WRITE transaction on Slave Address: 0xA0, Register Address: 0x13 Written Value: 0x05.
![Capture7](https://user-images.githubusercontent.com/38081550/117557372-07712200-b027-11eb-863e-0f7bd4ca6f8b.PNG)

* Running CLI on our own terminal emulator. Perform SPI READ (OP Code:03)  and WRITE (OP Code: 02) transaction on Register Address: 0x0b Written Value: 0x2525.
![Capture8](https://user-images.githubusercontent.com/38081550/117557374-1061f380-b027-11eb-8546-4e0aa20711a3.PNG)

### Using the GUI application to send the instruction and retrieve the result  
* I2C mode:
* * Check-in: DTR enable box, Always Update
* * Input the:  Slave address, ​Registered Address​, Num of Byte (READ mode), Byte Value (WRITE mode)
* * Click on: the ​READ button​ to to perform read, or the  the ​WRITE button​ to to perform write
* * Click on: The Clear Input button will clear the Input screen
* * Click on: The Clear Output button will clear the Output screen  
* * Click on: The Add Read Value button will add the record of your last transaction.
* * Click on: The Clear Grid button will empty the table. 

#### Simple user interface for I2C READ/ WRITE  with history table to track record
![Capture9](https://user-images.githubusercontent.com/38081550/117557466-faa0fe00-b027-11eb-841b-f9e39d3005ce.PNG)

#### Simple user interface for SPI READ/ WRITE  with history table to track record
![Capture10](https://user-images.githubusercontent.com/38081550/117557470-012f7580-b028-11eb-9239-cbde2e6eca8e.PNG)

### Video Demo 


<!-- Roadmap -->
## Roadmap 
* I2C firmware on Mbed in  December Fall 2020 
* * A demo parser for I2C on a terminal emulator for primary function in December Fall 2020 
* * A demo GUI application for I2C in early January Spring 2021 
* SPI firmware on Mbed for SPI in late January Spring 2021 
* * A demo parser for SPI on a terminal emulator for primary function in early February Spring 2021 
* * A demo GUI application for SPI in early late February  Spring 2021 
* Integration testing all part together in late March Spring 2021



