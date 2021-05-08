# SJSU-Senior-project


<!-- TABLE OF CONTENTS -->
<details open="open">
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
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

