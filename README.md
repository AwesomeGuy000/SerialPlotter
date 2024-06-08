# Simple Serial Port Data Reader, Writer & Plotter

This project was made to test the controller for the 2024 QUT DRC. It can read data from a serial port, display it in a text box as well as a graph, and can send data as well.

## Features

* Reads data from a specified serial port.
* Displays received data in a text box.
* Handles potential errors, such as unauthorized access or port closure.

## Installation

1. Ensure you have the necessary libraries installed for serial port communication.
2. Run the binary or compile from source.

## Usage

1. Run the application.
2. Choose your desired serial port and baud rate.
3. Any data received on the port will be displayed in the text box.
4. If it matches this predetermined format ```<0.00,0.00,0.00,0.00>```, it will also be plotted on the graph.

## Contributing

Contributions are welcome! Please open an issue or submit a pull request if you have any suggestions or improvements.
