package com.educacionit.funciones;

public class FuncionConUnParametro {
    public static void main(String[] args) {
        System.out.println("Inicio del programa");
        double iva = calcularIva(100); // Invocando funcion para calcular iva, y asignando el resultado a una variable
        System.out.println("Iva: " + iva);
        System.out.println("Fin del programa");
    }
    
    // Funcion que calcula el 21% de iva sobre un valor entero, pero retorna un double para soportar decimales
    public static double calcularIva(int valor) {
        return valor * 1.21;
    }
}
