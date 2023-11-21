package com.educacionit.procedimientos;

public class ProcedimientoConMultiplesParametros {
    public static void main(String[] args) {
        System.out.println("Inicio del programa");
        ejecutarCiclo(5, 10); // Invocando procedimiento
        System.out.println("Mitad del programa");
        ejecutarCiclo(15, 20); // Invocando procedimiento
        System.out.println("Fin del programa");
    }
    
    /*
     * Procedimiento que englobla una logica de codigo mas compleja para brindar legilibidad al codigo, 
     * y ademas reutilizacion pero de forma flexible recibiendo varios parametros.
     */
    public static void ejecutarCiclo(int inicio, int fin) {
        for (int i = inicio; i < fin; i++) {
            System.out.println("Contador: " + i);
        }
    }
}
