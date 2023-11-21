package com.educacionit.funciones;

public class FuncionConMultiplesParametros {
    public static void main(String[] args) {
        System.out.println("Inicio del programa");
        double iva = calcularIva(1200, 10.5); // Invocando funcion para calcular iva, y asignando el resultado a una variable
        System.out.println("Iva: " + iva);
        System.out.println("Fin del programa");
    }
    
    // Funcion que calcula el porcentaje que se pide por parametro sobre un valor tambien parametrizado.
    public static double calcularIva(int valor, double porcentaje) {
        return valor * porcentaje / 100;
    }
}
