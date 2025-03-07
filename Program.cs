using AES256;

//var aes = new EncryptionAndDecryption();
//
//string originalText = "Hello, AES-256!";
//Console.WriteLine($"Оригинальный текст: {originalText}");
//
//// Шифрование
//byte[] encryptedData = aes.Encrypt(originalText);
//string encryptedBase64 = Convert.ToBase64String(encryptedData);
//Console.WriteLine($"Зашифрованный текст (Base64): {encryptedBase64}");
//
//// Расшифрование
//string decryptedText = aes.Decrypt(Convert.FromBase64String(encryptedBase64));
//Console.WriteLine($"Расшифрованный текст: {decryptedText}");



FileCript fileCript = new FileCript();

fileCript.CreateFileCription("C:\\Users\\neroi\\Downloads\\Telegram Desktop\\test.hex",
    "C:\\Users\\neroi\\Desktop");

fileCript.CreateDecriptionFile("C:\\Users\\neroi\\Desktop\\Cription_test.hex",
    "C:\\Users\\neroi\\Desktop");