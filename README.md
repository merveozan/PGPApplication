
# PGP Encryption & Decryption Tool

## Overview
The PGP Encryption & Decryption Tool is a Windows Presentation Foundation (WPF) application that facilitates the encryption and decryption of text using RSA cryptography. It utilizes a 2048-bit RSA key, making it robust for educational purposes and small-scale secure communications.

## Features

- **RSA Encryption/Decryption**: Implements RSA cryptography to securely encrypt and decrypt messages.
- **User-Friendly Interface**: Features a simple and intuitive interface, enabling users to easily manage encryption and decryption processes.
- **Real-Time Interaction**: Provides immediate feedback for all cryptographic operations within the user-friendly GUI.

## Getting Started

### Prerequisites
- **.NET Core**
- **Visual Studio 2019** or later, with WPF development components installed.

### Installation

#### Clone the Repository
Start by cloning the repository to your local machine:

```bash
git clone https://github.com/merveozan/PGPApplicationTool.git
cd PGPApplicationTool
```

#### Open the Project
Navigate to the project directory and open the solution file (`PGPApplicationTool.sln`) in Visual Studio.

### Build and Run
- **Build the Application**: Navigate to `Build -> Build Solution` in Visual Studio.
- **Run the Application**: Launch the app by pressing `F5` or selecting `Start Debugging` from the toolbar.

### Usage Instructions
1. **Enter Text**: Input the text you wish to encrypt in the 'Input Text' box.
2. **Encrypt Text**: Press the 'Encrypt' button to encrypt the text. The encrypted output will be shown in the 'Encrypted Text' box.
3. **Decrypt Text**: With encrypted text in the appropriate box, click the 'Decrypt' button. The original text will be displayed in the 'Decrypted Text' box.

