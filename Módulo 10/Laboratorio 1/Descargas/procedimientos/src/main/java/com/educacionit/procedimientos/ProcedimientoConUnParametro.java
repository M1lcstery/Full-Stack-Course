package com.educacionit.procedimientos;

public class ProcedimientoConUnParametro {
    public static void main(String[] args) {
        System.out.println("Inicio del programa");
        ejecutarCiclo(10); // Invocando procedimiento
        System.out.println("Mitad del programa");
        ejecutarCiclo(20); // Invocando procedimiento
        System.out.println("Fin del programa");
    }
    
    /*
     * Procedimiento que englobla una logica de codigo mas compleja para brindar legilibidad al codigo, 
     * y ademas reutilizacion pero de forma flexible recibiendo un parametro.
     */
    public static void ejecutarCiclo(int maximo) {
        for (int i = 0; i < maximo; i++) {
            System.out.println("Contador: " + i);
        }
    }
}
