using System;
using System.Diagnostics;
using System.Threading;


Console.WriteLine("Bitte gebe eine stunden anzahl an"); 
int stunden = Convert.ToInt32(Console.ReadLine()); 
int stundenZuSekunden = stunden * 60 * 60; 
Console.WriteLine("Jetzt die Minuten. (Falls du nur stunden haben möchtest geb hier 0 ein)"); 
int minuten = Convert.ToInt32(Console.ReadLine()); 
int minutenZuSekunden = minuten * 60;
int sekunden = minutenZuSekunden + stundenZuSekunden;

string argumente = $"/s /t {sekunden}";
Process.Start("C:\\Windows\\System32\\shutdown.exe", argumente);
Console.WriteLine($"PC fährt in bald herunter...");

