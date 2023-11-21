package com.educacionit.procedimientos;

public class ProcedimientoReuso {
    public static void main(String[] args) {
        System.out.println("Inicio del programa");
        ejecutarCiclo(); // Invocando procedimiento
        System.out.println("Mitad del programa");
        ejecutarCiclo(); // Invocando procedimiento
        System.out.println("Fin del programa");
    }
    
    // Procedimiento que englobla una logica de codigo mas compleja para brindar legilibidad al codigo, y ademas reutilizacion
    public static void ejecutarCiclo() {
        for (int i = 0; i < 10; i++) {
            System.out.println("Contador: " + i);
        }
    }
}
