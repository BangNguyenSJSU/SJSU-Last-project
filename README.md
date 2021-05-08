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
