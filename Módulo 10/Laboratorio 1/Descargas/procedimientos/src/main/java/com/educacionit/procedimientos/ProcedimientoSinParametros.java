package com.educacionit.procedimientos;

public class ProcedimientoSinParametros {
    public static void main(String[] args) {
        System.out.println("Inicio del programa");
        cierreDeCaja(); // Invocando procedimiento
        System.out.println("Fin del programa");
    }
    
    // Procedimiento que englobla una logica de codigo mas compleja para brindar legilibidad al codigo
    public static void cierreDeCaja() {
        System.out.println("Iniciando cierre de caja");
        System.out.println("Ejecutando cierre de caja");
        System.out.println("Finalizando cierre de caja");
    }
}
