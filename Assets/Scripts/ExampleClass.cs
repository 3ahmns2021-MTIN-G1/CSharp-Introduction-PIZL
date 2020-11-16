// Bibliotheken/Asembly Refernce/Namespace
// grau: noch nichts aus dieser Bibliothek (vorgefertigte Klasse) verwendet, genannt
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Deklaration einer Klasse

// public            -> access modifier (Zugriffsrechte); keyword (vorreservierte Schlüsselwörter)
// class             -> keyword zur Deklaration einer Klasse
// ExampleClass      -> identifier (Name der Klasse)
// :MonoBehaivour    -> erstellen einer Unterklasse von MonoBehaivour
// {}                -> Scope/Wirkungsbereich (Was ist alles in der Klasse enthalten

// Klasse:  Säugetiere  -> Unterklasse: Hund
//                      -> Unterklasse: Katze

public class ExampleClass : MonoBehaviour
{
    // Deklaration von Variablen
    // Variablen sind Container für Value (Werte) oder Refernces (Verweise)

    // Variablentypen mit Values (Werten)
    // public                 -> access modifier (Wer darf von außen auf die Variable zugreifen)
    // int                    -> Variablen Typ (In diesem Fall ein Integer - Ganze Zahl)
    // ganzeZahlVariable      -> Identifier (Name der Variable)
    // ;                      -> Ende des Statements (Deklaration der Variable)

    public int ganzeZahlVariable; // Ganze Zahlen - Integer - Instanzvariable
    // Gleitkommazahlen
    // Text
    // Binäre Entscheidung (Boolscher Wert)


    public void TestFunktion()
    {
        // Variablen die NUR innerhalb der FUnktion gültig ist
    }
    
}
