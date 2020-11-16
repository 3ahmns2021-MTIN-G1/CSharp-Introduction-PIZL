// Bibliotheken/Asembly Refernce/Namespace
// grau: noch nichts aus dieser Bibliothek (vorgefertigte Klasse) verwendet, genannt
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    // Zuweisungsoperator (assignment operator) -> (Istlgeichzeichen) "="
    //!!! Beide Seiten des Zuweisungsoperators müssen den GLEICHEN TYPEN haben!
    public int ganzeZahlVariable = 4;        // Ganze Zahlen - Integer - Instanzvariable
    public float gleitkommaVariable = 4.2f;     // Gleitkommazahlen
    public string textVariable = "Hier kommt mein Text rein";          // Text
    public bool boolVariable = true;            // Binäre Entscheidung (Boolscher Wert)


    // Variablentypen mit References (Verweisen)
    public UnityEngine.Rigidbody rigidBodyVariable;
    public UnityEngine.BoxCollider boxColliderVariable;
    public BoxCollider boxColliderVariable2;
    public Transform transformVariable;
    public GameObject gameObjectVariable;
    public ExampleClass exampleClassVariable;
    public UnityEngine.UI.Button btnVariable;


    // Deklaration von Funktionen   (Was soll die Funktion machen) - TEIL1

    // public               -> access modifier (Wer darf die Funktion verwenden?)
    // void (kein Wert)     -> return type (Gibt die Funktion einen Wert zurück?) (Variablen Typen können zurückgegeben werden, zB float, string, Rigidbody, GameObject...)
    // Testfunktion         -> identifier (Name der Funktion unter der wir sie aufrufen können)
    // ()                   -> Parameterliste (hier gerade leer)
    // {}                   -> Scope / Geltungsbereich (Was ist in der Funktion enthalten)
    public void TestFunktion()
    {
        // Aufruf einer Funktion    (Wann soll die Funktion ausgeführt werden) - TEIL2

        // print            -> Name der Funktion
        // ()               -> Parameterliste mit Parametern
        // ;                -> Ende des Aufrufs
        print("Meine Nachricht an die Konsole");
    }

    // Automatisch von Unity aufgerufen im ersten Frame in der Scene. Bezieht sich aufs Objekt.
    public void Start()
    {
        TestFunktion(); 
    }

    public void Update()
    {
        // TestFunktion();
    }
}
