package com.educacionit.funciones;

public class FuncionSinParametros {
    public static void main(String[] args) {
        System.out.println("Inicio del programa");
        int valorRetornado = calcularValor(); // Invocando a la funcion y asignando el resultado a la variable "valorRetornado"
        System.out.println("Valor: " + valorRetornado);
        System.out.println("Fin del programa");
    }
    
    // Aqui vemos una funcion que no recibe parametros de entrada, lo cual es MUY poco pero valido.
    public static int calcularValor() {
        return 1;
    }
}
