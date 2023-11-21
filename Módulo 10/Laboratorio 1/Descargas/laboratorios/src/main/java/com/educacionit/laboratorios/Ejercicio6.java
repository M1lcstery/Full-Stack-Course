package com.educacionit.laboratorios;

public class Ejercicio6 {
    public static void main(String[] args) {
        cierreDelDia();
    }
    
    public static void cierreDelDia() {
        int total = 1200;
        double ivaReducido = iva(total, 10.5);
        double ivaTotal = iva(total, 21);
        
        System.out.println("IVA Reducido: " + ivaReducido);
        System.out.println("IVA Total: " + ivaTotal);
    }
    
    public static double iva(int valor, double porcentaje) {
        return valor * porcentaje / 100;
    }
}
