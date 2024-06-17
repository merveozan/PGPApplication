using System; // Basic C# library.
using System.Security.Cryptography; // Library for security and cryptography operations.
using System.Text; // Library for text operations.
using System.Windows; // Necessary library for a WPF application.

namespace PGPApplicationTool // Namespace of the application.
{
    public partial class MainWindow : Window // Main window class. Derived from the WPF Window class.
    {
        // RSA cryptography service provider instance created with a 2048-bit key size.
        private RSACryptoServiceProvider csp = new RSACryptoServiceProvider(2048);
        // Variables for public and private keys are defined.
        private RSAParameters publicKey;
        private RSAParameters privateKey;

        public MainWindow() // Constructor. Runs when the window is created.
        {
            InitializeComponent(); // Initializes the interface components created by XAML.
            publicKey = csp.ExportParameters(false); // Retrieves and stores the public key.
            privateKey = csp.ExportParameters(true); // Retrieves and stores the private key.
        }

        private void EncryptMessage(object sender, RoutedEventArgs e) // Called when the "Encrypt" button is pressed.
        {
            try
            {
                var csp2 = new RSACryptoServiceProvider(); // A new RSA service provider is created.
                csp2.ImportParameters(publicKey); // Public key is imported.

                // The text from InputText TextBox is converted to a Unicode byte array.
                var bytesPlainTextData = Encoding.Unicode.GetBytes(InputText.Text);
                // The byte array is encrypted using the public key.
                var bytesCypherText = csp2.Encrypt(bytesPlainTextData, false);
                // The encrypted byte array is converted to a Base64 string and displayed in the EncryptedText TextBox.
                EncryptedText.Text = Convert.ToBase64String(bytesCypherText);
            }
            catch (Exception ex) // If an error occurs during encryption, an error message is displayed.
            {
                MessageBox.Show("Encryption failed: " + ex.Message);
            }
        }

        private void DecryptMessage(object sender, RoutedEventArgs e) // Called when the "Decrypt" button is pressed.
        {
            try
            {
                csp.ImportParameters(privateKey); // Private key is imported.

                // The encrypted Base64 string from EncryptedText TextBox is converted back to a byte array.
                var bytesCypherText = Convert.FromBase64String(EncryptedText.Text);
                // The byte array is decrypted using the private key.
                var bytesPlainTextData = csp.Decrypt(bytesCypherText, false);
                // The decrypted byte array is converted to a Unicode string and displayed in the DecryptedText TextBox.
                DecryptedText.Text = Encoding.Unicode.GetString(bytesPlainTextData);
            }
            catch (Exception ex) // If an error occurs during decryption, an error message is displayed.
            {
                MessageBox.Show("Decryption failed: " + ex.Message);
            }
        }

        private void InputText_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }
    }
}
