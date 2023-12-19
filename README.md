# Szyfr - Blazor PWA

## Overview

Welcome to Szyfr, an Blazor PWA project designed to provide encryption and decryption functionalities for various ciphers. This project focuses on implementing the following ciphers:

1. **Szyfr Cezara (Caesar Cipher)**
2. **Szyfr Polibiusza z matematycznymi utrudnieniami szyfru (Polish Cipher with mathematical difficulties of the cipher)**
3. **Szyfr Trithemius'a (Trithemius Cipher)**
4. **Szyfr Vigenère'a (Vigenère Cipher)**

## Features

- **Szyfr Cezara (Caesar Cipher):**
  - Shifts characters in the plaintext by a fixed number.
  - Key is an integer representing the shift.

- **Szyfr Polibiusza z matematycznymi utrudnieniami szyfru (Polish Cipher with mathematical difficulties of the cipher):**
  - Maps each letter to its coordinates in a grid.
  - Converts letters into pairs of numbers.

- **Szyfr Trithemius'a (Trithemius Cipher):**
  - Incremental shift of characters based on position.
  - Key is a starting position for the shift.

- **Szyfr Vigenère'a (Vigenère Cipher):**
  - Uses a keyword to shift characters in the plaintext.
  - Each letter in the keyword represents a shift for the corresponding letter in the plaintext.

## Getting Started

1. **Clone the repository:**
```bash
git clone https://github.com/X-dante-X/Szyfr
```

2. **Go to project directory:**
```bash
cd "Szyfr/Szyfr"
```
3. **Run the application:**
```bash
   dotnet run
   ``` 
4. Access the application through your browser at https://localhost:5095 (port number may vary).

## Usage

1. Choose the desired cipher from the navigation menu.

2. Enter the plaintext and the required key or parameters.

3. Click the "Encrypt" or "Decrypt" button to perform the operation.

4. View the result in the corresponding output field.

## Contributing

If you'd like to contribute to this project, please follow these steps:

1. Fork the repository.

2. Create a new branch for your feature or bug fix.

3. Make changes and submit a pull request.

4. Your contribution will be reviewed, and feedback will be provided.

## License

This project is licensed under the [MIT License](LICENSE.md).

## Acknowledgments

Special thanks to anyone who contributed to the development of this project.

Feel free to reach out if you have any questions or issues!

