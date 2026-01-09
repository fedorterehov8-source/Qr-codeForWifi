// See https://aka.ms/new-console-template for more information
using QRCoder;
var wifi1 = new PayloadGenerator.WiFi(
    ssid: "Введите название сети",
    password: "Пароль от сетии",
    authenticationMode: PayloadGenerator.WiFi.Authentication.WPA);
var generator = new QRCodeGenerator();
var data = generator.CreateQrCode(wifi1.ToString(), QRCodeGenerator.ECCLevel.Q);
var qrCode = new PngByteQRCode(data);
byte[] pngBytes = qrCode.GetGraphic(20);
File.WriteAllBytes("wifi.png", pngBytes);
