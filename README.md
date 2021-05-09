# SJSU-Senior-project


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
    <li><a href="#usage">Usage</a></li>
    <li><a href="#roadmap">Roadmap</a></li>
    <li><a href="#contributing">Contributing</a></li>
    <li><a href="#license">License</a></li>
    <li><a href="#contact">Contact</a></li>
    <li><a href="#acknowledgements">Acknowledgements</a></li>
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
* * [Slave Device for Testing: I2C→ Human Body Temp Sensor MAX3020 ](https://www.maximintegrated.com/en/products/sensors/MAX30208EVSYS.html)
* * [Slave Device for Testing: SPI→ VS1053b (SPI) MIDI Audio Codec ](https://www.adafruit.com/product/1381?gclid=CjwKCAjw7diEBhB-EiwAskVi15HFjzuNsBJIbKIIrAkVQb-nS-RXtfBMl80TvxRCWkYuI-D4Eh5rLhoCEEwQAvD_BwE)
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
*  * You need to download and install all packet for Windows Forms App (. NET Framework) in Visual Studio Community 2019. [Visual Studio tutorials | C#](https://docs.microsoft.com/en-us/visualstudio/get-started/csharp/?view=vs-2019)

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


3. Clone the repo
   ```sh
   git clone https://github.com/your_username_/Project-Name.git
   ```
3. Install NPM packages
   ```sh
   npm install
   ```
4. Enter your API in `config.js`
   ```JS
   const API_KEY = 'ENTER YOUR API';
